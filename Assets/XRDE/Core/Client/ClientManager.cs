// Copyright ETRI(Electronics and Telecommunications Research Institute).
// Licensed under the MIT License.

using UnityEngine;
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Collections;
using System.Threading;

namespace XRDE
{
    [ScriptExecutionOrder(XRDEConstants.CLIENT_MANAGER_ORDER)]
    public class ClientManager : SingletonBehaviour<ClientManager>
    {
        #region Instpector
        public string ServerIP = "write IP address";
        public int Port = 50001;
        #endregion

        private TcpClient _tcpClient;

        private bool _isConnectingServer;

        public void StartClient()
        {
            if (!_isConnectingServer)
            {
                Debug.Log("[CLIENT] Start client.");

                try
                {
                    _tcpClient = new TcpClient(ServerIP, Port);

                    if (_tcpClient != null)
                    {
                        _isConnectingServer = true;

                        Debug.Log("[CLIENT] Server is connected: " + _tcpClient.Client.RemoteEndPoint.ToString());
                    }
                }
                catch (Exception e)
                {
                    Debug.Log("[CLIENT] Exception: " + e);
                }
            }        
        }

        private void FixedUpdate()
        {
            if (DataExtractorManager.SceneState != SceneState.Ready)
            {
                string json = JsonUtility.ToJson(DataExtractorManager.Data);

                if (_isConnectingServer)
                {
                    SendData(json);
                }
            }
        }

        protected override void OnDestroy()
        {
            CloseClient();
        }

        private void SendData(string json)
        {
            if (_tcpClient == null || !_tcpClient.Connected)
            {
                return;
            }

            try
            {
                NetworkStream stream = _tcpClient.GetStream();

                if (stream.CanWrite)
                {
                    byte[] packet = Encoding.UTF8.GetBytes(json);
                    stream.Write(packet, 0, packet.Length);
                }
            }
            catch (SocketException e)
            {
                Debug.Log("[CLIENT] SocketException: " + e);
            }
        }

        public void ResetClient()
        {
            Debug.Log("[CLIENT] Reset Client......");
            StartCoroutine(Reset());
        }

        private IEnumerator Reset()
        {
            yield return new WaitForSeconds(1);
            CloseClient();
            yield return new WaitForSeconds(1);
            StartClient();
        }

        public void CloseClient()
        {
            _isConnectingServer = false;

            if (_tcpClient != null)
            {
                _tcpClient.Close();
                _tcpClient = null;
            }

            Debug.Log("[CLIENT] Stop Client.");
        }
    }
}
