// Copyright ETRI(Electronics and Telecommunications Research Institute).
// Licensed under the MIT License.

using UnityEngine;
using System.Collections;

namespace XRDE
{
    public class LoggerOnGUI : MonoBehaviour
    {
        #region inspector
        public Vector2 CenterPivot = new Vector2(0, 0);
        public int Width = 600;
        public int Height = 400;
        #endregion

        private Queue _logQueue = new Queue();
        private uint _logMaxLength = 20;

        private void OnEnable()
        {
            Application.logMessageReceivedThreaded += HandleLog;
        }

        private void OnDisable()
        {
            Application.logMessageReceivedThreaded += HandleLog;
        }

        private void OnGUI()
        {
            GUILayout.BeginArea(new Rect(Screen.width/2 + CenterPivot.x - Width/2, Screen.height/2 + CenterPivot.y - Height/2, Width, Height));
            GUILayout.Label("\n" + string.Join("\n", _logQueue.ToArray()));
            GUILayout.EndArea();
        }

        private void HandleLog(string log, string stackTrace, LogType type)
        {
            _logQueue.Enqueue("[" + type + "] : " + log);

            if (type == LogType.Exception)
            {
                //_logQueue.Enqueue(stackTrace);
            }
            while (_logQueue.Count > _logMaxLength)
            {
                _logQueue.Dequeue();
            }
        }
    }
}
