namespace UDP_UI
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.outputTxt = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.portBox = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.RelaunchBtn = new System.Windows.Forms.Button();
            this.messageSendTxt = new System.Windows.Forms.TextBox();
            this.sendPortTxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.IPTxt = new System.Windows.Forms.TextBox();
            this.menuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // outputTxt
            // 
            this.outputTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.outputTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputTxt.Cursor = System.Windows.Forms.Cursors.Default;
            this.outputTxt.ForeColor = System.Drawing.Color.White;
            this.outputTxt.HideSelection = false;
            this.outputTxt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.outputTxt.Location = new System.Drawing.Point(12, 33);
            this.outputTxt.Name = "outputTxt";
            this.outputTxt.ReadOnly = true;
            this.outputTxt.Size = new System.Drawing.Size(529, 233);
            this.outputTxt.TabIndex = 0;
            this.outputTxt.TabStop = false;
            this.outputTxt.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Incoming Data (UDP Server)";
            // 
            // portBox
            // 
            this.portBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.portBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.portBox.ForeColor = System.Drawing.Color.White;
            this.portBox.Location = new System.Drawing.Point(210, 4);
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size(91, 23);
            this.portBox.TabIndex = 3;
            this.portBox.TabStop = false;
            this.portBox.Text = "6969";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.ForeColor = System.Drawing.Color.White;
            this.lblPort.Location = new System.Drawing.Point(172, 7);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(32, 15);
            this.lblPort.TabIndex = 2;
            this.lblPort.Text = "Port:";
            // 
            // RelaunchBtn
            // 
            this.RelaunchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.RelaunchBtn.FlatAppearance.BorderSize = 0;
            this.RelaunchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RelaunchBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RelaunchBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.RelaunchBtn.Location = new System.Drawing.Point(307, 4);
            this.RelaunchBtn.Name = "RelaunchBtn";
            this.RelaunchBtn.Size = new System.Drawing.Size(231, 23);
            this.RelaunchBtn.TabIndex = 0;
            this.RelaunchBtn.TabStop = false;
            this.RelaunchBtn.Text = "Relaunch Socket";
            this.RelaunchBtn.UseVisualStyleBackColor = true;
            this.RelaunchBtn.Click += new System.EventHandler(this.LaunchSocketBtn);
            // 
            // messageSendTxt
            // 
            this.messageSendTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.messageSendTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.messageSendTxt.ForeColor = System.Drawing.Color.White;
            this.messageSendTxt.Location = new System.Drawing.Point(12, 285);
            this.messageSendTxt.Name = "messageSendTxt";
            this.messageSendTxt.Size = new System.Drawing.Size(529, 23);
            this.messageSendTxt.TabIndex = 5;
            this.messageSendTxt.Text = "Hello World";
            // 
            // sendPortTxt
            // 
            this.sendPortTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.sendPortTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sendPortTxt.ForeColor = System.Drawing.Color.White;
            this.sendPortTxt.Location = new System.Drawing.Point(373, 314);
            this.sendPortTxt.Name = "sendPortTxt";
            this.sendPortTxt.Size = new System.Drawing.Size(105, 23);
            this.sendPortTxt.TabIndex = 6;
            this.sendPortTxt.Text = "6969";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(484, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 23);
            this.button1.TabIndex = 7;
            this.button1.TabStop = false;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.SendBtn);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Outgoing Data (UDP Client)";
            // 
            // IPTxt
            // 
            this.IPTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.IPTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IPTxt.ForeColor = System.Drawing.Color.White;
            this.IPTxt.Location = new System.Drawing.Point(12, 314);
            this.IPTxt.Name = "IPTxt";
            this.IPTxt.Size = new System.Drawing.Size(355, 23);
            this.IPTxt.TabIndex = 9;
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.menuButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuButton.FlatAppearance.BorderSize = 0;
            this.menuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuButton.ForeColor = System.Drawing.Color.White;
            this.menuButton.Location = new System.Drawing.Point(547, 0);
            this.menuButton.Margin = new System.Windows.Forms.Padding(0);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(31, 355);
            this.menuButton.TabIndex = 10;
            this.menuButton.TabStop = false;
            this.menuButton.Text = "+";
            this.menuButton.UseVisualStyleBackColor = false;
            this.menuButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(578, 355);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.IPTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sendPortTxt);
            this.Controls.Add(this.messageSendTxt);
            this.Controls.Add(this.RelaunchBtn);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.portBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outputTxt);
            this.Name = "Main";
            this.Text = "UDP UTF-8 Communicator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox outputTxt;
        private Label label1;
        private Label lblPort;
        private Button RelaunchBtn;
        public TextBox portBox;
        private TextBox messageSendTxt;
        private TextBox sendPortTxt;
        private Button button1;
        private Label label2;
        private TextBox IPTxt;
        private Button menuButton;
    }
}