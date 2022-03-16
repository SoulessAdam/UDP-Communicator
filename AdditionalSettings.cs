namespace UDP_UI
{
    public partial class AdditionalSettings : Form
    {
        public AdditionalSettings()
        {
            InitializeComponent();
        }

        public void incomingSaveBtn_click(object sender, EventArgs e)
        {
            if (incomingKeyTxt.Text != null && System.Text.Encoding.UTF8.GetBytes(incomingKeyTxt.Text).Length == 16) {
                Main.mainHandle.Aes.setDecryptKey(System.Text.Encoding.UTF8.GetBytes(incomingKeyTxt.Text));
            } else {
                MessageBox.Show("Invalid Key", "Key not set.\n(Must be 16 bytes long in UTF-8 Format)", MessageBoxButtons.OK);
            }
        }

        private void outgoingSaveBtn_click(object sender, EventArgs e)
        {
            if (outgoingKeyTxt.Text != null && System.Text.Encoding.UTF8.GetBytes(outgoingKeyTxt.Text).Length == 16) {
                Main.mainHandle.Aes.setEncryptKey(System.Text.Encoding.UTF8.GetBytes(outgoingKeyTxt.Text));
            }
            else
            {
                MessageBox.Show("Invalid Key", "Key not set.\n(Must be 16 bytes long in UTF-8 Format)", MessageBoxButtons.OK);
            }
        }
    }
}

