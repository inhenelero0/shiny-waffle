//put later here

        private void ConnectionButton_Click(object sender, EventArgs e)
        {
            if (Arduino.IsConnected())
            {
                ConnectGroup.Text = "Disconnectiong...";
                Arduino.Disconnect();
            }
            else
            {
                ConnectGroup.Text = "Connecting...";
                string selectedPort = Ports.GetItemText(Ports.SelectedItem);
                if(Arduino.Conect(selectedPort))
                {
                    S.Default.DefaultPort = selectedPort;
                    S.Default.Save();
                }
            }
            StatusChange();
        }
//code
  protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
