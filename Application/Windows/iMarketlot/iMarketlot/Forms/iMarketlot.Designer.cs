namespace iMarketlot
{
    partial class FormiMarketlot
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
            this.rtbChatLog = new System.Windows.Forms.RichTextBox();
            this.labelServerStatus = new System.Windows.Forms.Label();
            this.pictureboxServerStatus = new iMarketlot.OvalPictureBox();
            this.labelServerIP = new System.Windows.Forms.Label();
            this.labelServerIPValue = new System.Windows.Forms.Label();
            this.panelStatus = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxServerStatus)).BeginInit();
            this.panelStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbChatLog
            // 
            this.rtbChatLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rtbChatLog.ForeColor = System.Drawing.Color.White;
            this.rtbChatLog.Location = new System.Drawing.Point(12, 265);
            this.rtbChatLog.Name = "rtbChatLog";
            this.rtbChatLog.ReadOnly = true;
            this.rtbChatLog.Size = new System.Drawing.Size(190, 173);
            this.rtbChatLog.TabIndex = 0;
            this.rtbChatLog.Text = "";
            // 
            // labelServerStatus
            // 
            this.labelServerStatus.AutoSize = true;
            this.labelServerStatus.Location = new System.Drawing.Point(9, 26);
            this.labelServerStatus.Name = "labelServerStatus";
            this.labelServerStatus.Size = new System.Drawing.Size(74, 13);
            this.labelServerStatus.TabIndex = 1;
            this.labelServerStatus.Text = "Server Status:";
            // 
            // pictureboxServerStatus
            // 
            this.pictureboxServerStatus.BackColor = System.Drawing.Color.DarkGray;
            this.pictureboxServerStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureboxServerStatus.Location = new System.Drawing.Point(86, 26);
            this.pictureboxServerStatus.Name = "pictureboxServerStatus";
            this.pictureboxServerStatus.Size = new System.Drawing.Size(13, 13);
            this.pictureboxServerStatus.TabIndex = 2;
            this.pictureboxServerStatus.TabStop = false;
            // 
            // labelServerIP
            // 
            this.labelServerIP.AutoSize = true;
            this.labelServerIP.Location = new System.Drawing.Point(9, 13);
            this.labelServerIP.Name = "labelServerIP";
            this.labelServerIP.Size = new System.Drawing.Size(54, 13);
            this.labelServerIP.TabIndex = 3;
            this.labelServerIP.Text = "Server IP:";
            // 
            // labelServerIPValue
            // 
            this.labelServerIPValue.AutoSize = true;
            this.labelServerIPValue.Location = new System.Drawing.Point(65, 13);
            this.labelServerIPValue.Name = "labelServerIPValue";
            this.labelServerIPValue.Size = new System.Drawing.Size(40, 13);
            this.labelServerIPValue.TabIndex = 4;
            this.labelServerIPValue.Text = "0.0.0.0";
            // 
            // panelStatus
            // 
            this.panelStatus.AutoSize = true;
            this.panelStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelStatus.Controls.Add(this.labelServerIP);
            this.panelStatus.Controls.Add(this.pictureboxServerStatus);
            this.panelStatus.Controls.Add(this.labelServerIPValue);
            this.panelStatus.Controls.Add(this.labelServerStatus);
            this.panelStatus.Location = new System.Drawing.Point(12, 25);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(190, 234);
            this.panelStatus.TabIndex = 5;
            // 
            // FormiMarketlot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelStatus);
            this.Controls.Add(this.rtbChatLog);
            this.Name = "FormiMarketlot";
            this.Text = "iMarketlot";
            this.Load += new System.EventHandler(this.FormiMarketlot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxServerStatus)).EndInit();
            this.panelStatus.ResumeLayout(false);
            this.panelStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbChatLog;
        private System.Windows.Forms.Label labelServerStatus;
        private OvalPictureBox pictureboxServerStatus;
        private System.Windows.Forms.Label labelServerIP;
        private System.Windows.Forms.Label labelServerIPValue;
        private System.Windows.Forms.Panel panelStatus;
    }
}

