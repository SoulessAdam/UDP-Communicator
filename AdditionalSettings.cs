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
            if (incomingKeyTxt.Text != null && incomingKeyTxt.Text.Length == 16) {
                Main.incomingDecrypt = true;
                //Main.AesModule
            } else {
                MessageBox.Show("Invalid Key (Must be 16 bytes long)", "Decryption has now been disabled until a valid key has been entered");
                Main.incomingDecrypt = false;
            }
        }
    }
}

