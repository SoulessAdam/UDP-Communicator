namespace UDP_UI
{
    partial class AdditionalSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.incomingKeyTxt = new System.Windows.Forms.TextBox();
            this.incomingSaveBtn = new System.Windows.Forms.Button();
            this.outgoingKeyTxt = new System.Windows.Forms.TextBox();
            this.outgoingSaveBtn = new System.Windows.Forms.Button();
            this.Disclaimer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // incomingKeyTxt
            // 
            this.incomingKeyTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.incomingKeyTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.incomingKeyTxt.Location = new System.Drawing.Point(12, 42);
            this.incomingKeyTxt.Name = "incomingKeyTxt";
            this.incomingKeyTxt.Size = new System.Drawing.Size(131, 23);
            this.incomingKeyTxt.TabIndex = 0;
            // 
            // incomingSaveBtn
            // 
            this.incomingSaveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.incomingSaveBtn.FlatAppearance.BorderSize = 0;
            this.incomingSaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.incomingSaveBtn.ForeColor = System.Drawing.Color.White;
            this.incomingSaveBtn.Location = new System.Drawing.Point(150, 42);
            this.incomingSaveBtn.Name = "incomingSaveBtn";
            this.incomingSaveBtn.Size = new System.Drawing.Size(65, 23);
            this.incomingSaveBtn.TabIndex = 1;
            this.incomingSaveBtn.Text = "Save";
            this.incomingSaveBtn.UseVisualStyleBackColor = false;
            this.incomingSaveBtn.Click += new System.EventHandler(this.incomingSaveBtn_click);
            // 
            // outgoingKeyTxt
            // 
            this.outgoingKeyTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.outgoingKeyTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outgoingKeyTxt.Location = new System.Drawing.Point(12, 105);
            this.outgoingKeyTxt.Name = "outgoingKeyTxt";
            this.outgoingKeyTxt.Size = new System.Drawing.Size(131, 23);
            this.outgoingKeyTxt.TabIndex = 2;
            // 
            // outgoingSaveBtn
            // 
            this.outgoingSaveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.outgoingSaveBtn.FlatAppearance.BorderSize = 0;
            this.outgoingSaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.outgoingSaveBtn.ForeColor = System.Drawing.Color.White;
            this.outgoingSaveBtn.Location = new System.Drawing.Point(150, 105);
            this.outgoingSaveBtn.Name = "outgoingSaveBtn";
            this.outgoingSaveBtn.Size = new System.Drawing.Size(65, 23);
            this.outgoingSaveBtn.TabIndex = 3;
            this.outgoingSaveBtn.Text = "Save";
            this.outgoingSaveBtn.UseVisualStyleBackColor = false;
            this.outgoingSaveBtn.Click += new System.EventHandler(this.outgoingSaveBtn_click);
            // 
            // Disclaimer
            // 
            this.Disclaimer.AutoSize = true;
            this.Disclaimer.ForeColor = System.Drawing.Color.White;
            this.Disclaimer.Location = new System.Drawing.Point(12, 163);
            this.Disclaimer.Name = "Disclaimer";
            this.Disclaimer.Size = new System.Drawing.Size(180, 15);
            this.Disclaimer.TabIndex = 4;
            this.Disclaimer.Text = "* Raw byte support coming soon";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Incoming Data Key:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Outgoing Data Key:";
            // 
            // AdditionalSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(221, 187);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Disclaimer);
            this.Controls.Add(this.outgoingSaveBtn);
            this.Controls.Add(this.outgoingKeyTxt);
            this.Controls.Add(this.incomingSaveBtn);
            this.Controls.Add(this.incomingKeyTxt);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Name = "AdditionalSettings";
            this.Text = "Additional Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox incomingKeyTxt;
        private Button incomingSaveBtn;
        private TextBox outgoingKeyTxt;
        private Button outgoingSaveBtn;
        private Label Disclaimer;
        private Label label1;
        private Label label2;
    }
}