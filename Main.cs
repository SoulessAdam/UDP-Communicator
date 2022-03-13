using System;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace UDP_UI
{
    public partial class Main : Form
    {
        UdpClient Client;
        IPEndPoint endPoint;
        Thread thread;
        AdditionalSettings Settings = new AdditionalSettings();
        bool b_MenuOpen = false;

        public Main()
        {
            InitializeComponent();
            InitSendTxt();  
            InitSocket();
            StartLoops();
        }


        public void InitSendTxt()
        {
            IPAddress[] Addresses = Dns.GetHostEntry(Dns.GetHostName()).AddressList;
            foreach(IPAddress address in Addresses)
            {
                if(address.AddressFamily == AddressFamily.InterNetwork)
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
            if(Client != null) { Client.Close(); Client.Dispose(); }
            Client = new UdpClient(int.Parse(portBox.Text));
            endPoint = new IPEndPoint(IPAddress.Any, int.Parse(portBox.Text));
        }

        public void ListenLoop()
        {
            while(Client != null)
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
            if (!b_MenuOpen) {
                Settings.Show();
                b_MenuOpen = true;
                menuButton.Text = "X";
            } else {
                Settings.Hide();
                b_MenuOpen = false;
                menuButton.Text = "+";
            }
        }
    }
}