using iMarketlot.Properties;
using System.Drawing;

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
            this.Icon = Icon.FromHandle(Properties.Resources.logo.GetHicon());
            this.rtbChatLog = new System.Windows.Forms.RichTextBox();
            this.labelServerStatus = new System.Windows.Forms.Label();
            this.pictureboxServerStatus = new iMarketlot.OvalPictureBox();
            this.labelServerIP = new System.Windows.Forms.Label();
            this.labelServerIPValue = new System.Windows.Forms.Label();
            this.panelStatus = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.configToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxServerStatus)).BeginInit();
            this.panelStatus.SuspendLayout();
            this.menuStrip1.SuspendLayout();
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
            this.panelStatus.Location = new System.Drawing.Point(12, 45);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(190, 214);
            this.panelStatus.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // configToolStripMenuItem
            // 
            this.configToolStripMenuItem.Name = "configToolStripMenuItem";
            this.configToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.configToolStripMenuItem.Text = "Config";
            this.configToolStripMenuItem.Click += new System.EventHandler(this.configToolStripMenuItem_Click);
            // 
            // FormiMarketlot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelStatus);
            this.Controls.Add(this.rtbChatLog);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormiMarketlot";
            this.Text = "iMarketlot";
            this.Load += new System.EventHandler(this.FormiMarketlot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxServerStatus)).EndInit();
            this.panelStatus.ResumeLayout(false);
            this.panelStatus.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem configToolStripMenuItem;
    }
}

