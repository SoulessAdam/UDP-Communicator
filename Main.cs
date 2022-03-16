using System.Net;
using System.Net.Sockets;

namespace UDP_UI
{
    public partial class Main : Form
    {
        public static bool incomingDecrypt = false;
        public static bool outgoingDecrypt = false;
        public static Main mainHandle;
        Modules.Encryption.AesModule Aes = new Modules.Encryption.AesModule();
        UdpClient Client;
        IPEndPoint endPoint;
        Thread thread;
        AdditionalSettings Settings = new AdditionalSettings();
        bool b_MenuOpen = false;
        bool b_MenuDisposed = false;
        public int a;

        public Main()
        {
            InitializeComponent();
            mainHandle = this;
            setDisposalHook();
            InitSendTxt();
            InitSocket();
            StartLoops();
            
        }


        public void setDisposalHook()
        {
            Settings.Disposed += event_SettingsDisposed;
        }

        public void event_SettingsDisposed(object? sender, EventArgs e)
        {
            b_MenuOpen = false;
            b_MenuDisposed = true;
            Invoke(new Action(() =>
            {
                menuButton.Text = "+";
            }));
        }
        public void InitSendTxt()
        {
            IPAddress[] Addresses = Dns.GetHostEntry(Dns.GetHostName()).AddressList;
            foreach (IPAddress address in Addresses)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    IPTxt.Text = address.ToString();
                    break;
                }
            }
        }

        public void StartLoops()
        {
            thread = new Thread(() => ListenLoop());
            thread.IsBackground = true;
            thread.Start();
        }

        public void InitSocket()
        {
            if (Client != null) { Client.Close(); Client.Dispose(); }
            Client = new UdpClient(int.Parse(portBox.Text));
            endPoint = new IPEndPoint(IPAddress.Any, int.Parse(portBox.Text));
        }

        public void ListenLoop()
        {
            while (Client != null)
            {
                try
                {
                    var Bytes = Client.Receive(ref endPoint);
                    Invoke(new Action(() => { outputTxt.AppendText($"{endPoint} <<< {System.Text.Encoding.UTF8.GetString(Bytes)}{Environment.NewLine}"); }));
                }
                catch (Exception ex) { }
            }
        }

        private void LaunchSocketBtn(object sender, EventArgs e)
        {
            InitSocket();
        }

        private void SendBtn(object sender, EventArgs e)
        {
            var text = System.Text.Encoding.UTF8.GetBytes(messageSendTxt.Text);
            IPEndPoint endpnt = new IPEndPoint(IPAddress.Parse(IPTxt.Text), int.Parse(sendPortTxt.Text));
            Client.Send(text, endpnt);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Settings.IsDisposed) { Settings = new AdditionalSettings(); b_MenuDisposed = false; setDisposalHook(); };
            if (!b_MenuOpen)
            {
                Settings.Show();
                b_MenuOpen = true;
                menuButton.Text = "x";
            }
            else
            {
                Settings.Hide();
                b_MenuOpen = false;
                menuButton.Text = "+";
            }
        }

        private void debugBtn_Click(object sender, EventArgs e)
        {
            Aes.setEncryptKey(System.Text.Encoding.UTF8.GetBytes("SIXTEENCHARACTRS"));
            Aes.setDecryptKey(System.Text.Encoding.UTF8.GetBytes("SIXTEENCHARACTRS"));
            var b = Aes.encryptOutgoing("Test Message");
            //outputTxt.AppendText("[DEBUG ENCRYPT] <<< " + "Message: " + Convert.ToBase64String(b[1]) + $" Key: SIXTEENCHARACTRS IV: {Convert.ToBase64String(b[0])}" +Environment.NewLine);
            outputTxt.AppendText($"[TESTING DECRYPT] {Aes.decryptIncoming(b)} {Environment.NewLine}");
        }

        public void invokeWrite(string text)
        {
            outputTxt.Invoke(new Action(() =>
            {
                outputTxt.AppendText(text);
            }));
        }
    }
}
