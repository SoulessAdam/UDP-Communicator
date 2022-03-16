using System.Net;
using System.Net.Sockets;

namespace UDP_UI
{
    public partial class Main : Form
    {
        public static bool incomingDecrypt = false;
        public static bool outgoingEncrypt = false;
        public bool clientInit = false;
        public static Main mainHandle;
        public Modules.Encryption.AesModule Aes = new Modules.Encryption.AesModule();
        static UdpClient? Client;
        IPEndPoint? endPoint;
        Thread? thread;
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
            
        }


        public void setDisposalHook()
        {
            Settings.Disposed += event_SettingsDisposed;
        }

        public void event_SettingsDisposed(object? sender, EventArgs e)
        {
            b_MenuOpen = false;
            b_MenuDisposed = true;
            try
            {
                Invoke(new Action(() =>
                {
                    menuButton.Text = "+";
                }));
            }
            catch (Exception ex) { Application.Exit(); };
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

        public async void InitSocket()
        {
            if (Client != null) { Client.Close(); Client.Dispose(); clientInit = false; }
            Client = new UdpClient(int.Parse(portBox.Text));
            endPoint = new IPEndPoint(IPAddress.Any, int.Parse(portBox.Text));
            await Task.Delay(500);
            clientInit = true;
            StartLoops();
        }

        public void ListenLoop()
        {
            while (Client != null && clientInit)
            {
                try {
                    var t_messageBytes = Client.Receive(ref endPoint);
                    var t_message = System.Text.Encoding.UTF8.GetString(t_messageBytes);
                    string incomingMessage;
                    if (incomingDecrypt && Aes.incomingKeySet) {
                        incomingMessage = Aes.decryptIncoming(t_message); 
                    } else {
                        incomingMessage = t_message;
                    }
                    Invoke(new Action(() => { outputTxt.AppendText($"{endPoint} <<< {incomingMessage}{Environment.NewLine}"); }));
                }
                catch(System.Net.Sockets.SocketException) { }
                catch (Exception ex) {
                    MessageBox.Show(ex.StackTrace, ex.Message);
                }
            }
        }

        private void LaunchSocketBtn(object sender, EventArgs e)
        {
            InitSocket();
        }

        private void SendBtn(object sender, EventArgs e)
        {
            string t_Message = messageSendTxt.Text;
            string message;
            if (outgoingEncrypt && Aes.outgoingKeySet) {
                message = Aes.encryptOutgoing(t_Message);
            } else {
                message = t_Message;
            }
            IPEndPoint endpnt = new IPEndPoint(IPAddress.Parse(IPTxt.Text), int.Parse(sendPortTxt.Text));
            Client.Send(System.Text.Encoding.UTF8.GetBytes(message), endpnt);
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

        public void invokeWrite(string text)
        {
            outputTxt.Invoke(new Action(() =>
            {
                outputTxt.AppendText(text);
            }));
        }


        bool o_messageShown = false; // Setting bools so that when reversing the checkbox change, only one message box is shown.
        bool i_messageShown = false;
        private void outgoingCheckBoxUpdated(object sender, EventArgs e)
        {
            if(!Aes.outgoingKeySet) { 
                if (!o_messageShown) { 
                    MessageBox.Show("Key is not set, option not valid.", "Decryption Error"); 
                }
                o_messageShown = !o_messageShown;
                outgoingCheckBox.Checked = false; 
            }
            outgoingEncrypt = outgoingCheckBox.Checked;
        }

        private void incomingCheckBoxUpdated(object sender, EventArgs e)
        {
            if(!Aes.incomingKeySet) { 
                if (!i_messageShown) {
                    MessageBox.Show("Key is not set, option not valid.", "Encryption Error"); 
                }
                i_messageShown = !i_messageShown;
                incomingCheckBox.Checked = false; 
            }
            incomingDecrypt = incomingCheckBox.Checked;
        }
    }
}
