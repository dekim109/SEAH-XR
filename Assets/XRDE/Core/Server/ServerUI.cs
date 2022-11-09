// Copyright ETRI(Electronics and Telecommunications Research Institute).
// Licensed under the MIT License.

using UnityEngine;
using UnityEngine.UI;

namespace XRDE
{
    public class ServerUI : MonoBehaviour
    {
        #region Instpector
        public InputField PortInputField;
        public InputField SubjectNumberInputField;
        public Button StartButton;
        public Button ResetButton;
        public Button CloseButton;
        public Button OpenFolderButton;
        #endregion

        private string _prevPortText = "";
        private string _prevSubjectNumberText = "";

        private void Start()
        {
            // Set build app window size
            Screen.SetResolution(1280, 720, false);

            // Connect each UI and action
            if (PortInputField)
            {
                PortInputField.text = "50001";
                ServerManager.Instance.Port = int.Parse(PortInputField.text);
            }

            if (SubjectNumberInputField)
            {
                SubjectNumberInputField.text = "001";
                CSVWriter.SubjectNumber = SubjectNumberInputField.text;
            }

            if (StartButton)
            {
                StartButton.onClick.AddListener(ServerManager.Instance.StartServer);
            }

            if (ResetButton)
            {
                ResetButton.onClick.AddListener(ServerManager.Instance.ResetServer);
            }

            if (CloseButton)
            {
                CloseButton.onClick.AddListener(ServerManager.Instance.CloseServer);
            }

            if (OpenFolderButton)
            {
                OpenFolderButton.onClick.AddListener(CSVWriter.Instance.OpenCSVFolder);
            }
        }

        private void Update()
        {
            UpdatePort();
        }

        private void UpdatePort()
        {
            if (PortInputField)
            {
                string port_text = PortInputField.text;
                if (_prevPortText != port_text)
                {
                    int port_int;
                    if (int.TryParse(port_text, out port_int) && !string.IsNullOrEmpty(port_text))
                    {
                        ServerManager.Instance.Port = int.Parse(PortInputField.text);
                        _prevPortText = port_text;
                    }
                }
            }

            if (SubjectNumberInputField)
            {
                string SubjectNumber_text = SubjectNumberInputField.text;
                if(_prevSubjectNumberText != SubjectNumber_text)
                {
                    CSVWriter.SubjectNumber = SubjectNumberInputField.text;
                    _prevSubjectNumberText = SubjectNumber_text;
                }
            }
        }
    }
}
