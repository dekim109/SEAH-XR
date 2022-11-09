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
    public class ServerManager : SingletonBehaviour<ServerManager>
    {
        #region Instpector
        public int Port = 50001;
        #endregion

        private TcpListener _tcpListener;
        private Thread _tcpListenerThread;
        private TcpClient _connectedTcpClient;

        private bool _isThreadStarted;
        private bool _isClientConnected;

        public static XRData ReceivedData = null;

        private void OnEnable()
        {
            Debug.Log("[SERVER] Start server application.");
        }

        protected override void OnDestroy()
        {
            CloseServer();
        }

        public void StartServer()
        {
            if (!_isThreadStarted)
            {
                _tcpListenerThread = new Thread(new ThreadStart(ListenData));
                _tcpListenerThread.IsBackground = true;
                _tcpListenerThread.Start();

                _isThreadStarted = true;

                Debug.Log("[SERVER] Start server. (Port number: " + Port + ")");
                Debug.Log("[SERVER] Current subject number: " + CSVWriter.SubjectNumber);
            }
        }

        private void ListenData()
        {
            try
            {
                // Create listener
                _tcpListener = new TcpListener(IPAddress.Any, 50001);
                _tcpListener.Start();
                Debug.Log("[SERVER] Server is listening......");

                while (true)
                {
                    using (_connectedTcpClient = _tcpListener.AcceptTcpClient())
                    {
                        if (!_isClientConnected)
                        {
                            _isClientConnected = true;

                            Debug.Log("[SERVER] Client is connected: " + _connectedTcpClient.Client.RemoteEndPoint.ToString());
                        }

                        using (NetworkStream stream = _connectedTcpClient.GetStream())
                        {
                            byte[] packet = new byte[4096];
                            int length;

                            Debug.Log("[SERVER] Hold stream......");

                            while ((length = stream.Read(packet, 0, packet.Length)) != 0)
                            {
                                byte[] receivedPacket = new byte[length];
                                Array.Copy(packet, 0, receivedPacket, 0, length);
                                string packet_json = Encoding.UTF8.GetString(receivedPacket);
                                ReceivedData = JsonUtility.FromJson<XRData>(packet_json);

                                Debug.Log("received data: [" + ReceivedData.TimeData[0] + "] , " + ReceivedData.SceneData[0]);
                            }
                        }
                    }
                }
            }
            catch (SocketException e)
            {
                Debug.Log("[SERVER] SocketException: " + e);
            }
        }

        public void ResetServer()
        {
            Debug.Log("[SERVER] Reset server......");

            StartCoroutine(Reset());
        }

        private IEnumerator Reset()
        {
            yield return new WaitForSeconds(1);
            CloseServer();
            yield return new WaitForSeconds(1);
            StartServer();
        }

        public void CloseServer()
        {
            _isThreadStarted = false;
            _isClientConnected = false;

            if (_tcpListenerThread != null)
            {
                _tcpListenerThread.Abort();
                _tcpListenerThread = null;
            }

            if (_tcpListener != null)
            {
                _tcpListener.Stop();
                _tcpListener = null;
            }

            if (_connectedTcpClient != null)
            {
                _connectedTcpClient.Close();
                _connectedTcpClient = null;
            }

            Debug.Log("[SERVER] Stop server.");
        }
    }
}
