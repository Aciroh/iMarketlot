namespace iMarketlot
{
    partial class FormConfiguration
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
            this.textBoxEXE = new System.Windows.Forms.TextBox();
            this.labelEXE = new System.Windows.Forms.Label();
            this.labelInstancePath = new System.Windows.Forms.Label();
            this.textBoxInstance = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.labelAPIKey = new System.Windows.Forms.Label();
            this.textBoxAPIKey = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxEXE
            // 
            this.textBoxEXE.Location = new System.Drawing.Point(12, 31);
            this.textBoxEXE.Name = "textBoxEXE";
            this.textBoxEXE.Size = new System.Drawing.Size(191, 20);
            this.textBoxEXE.TabIndex = 0;
            // 
            // labelEXE
            // 
            this.labelEXE.AutoSize = true;
            this.labelEXE.Location = new System.Drawing.Point(12, 15);
            this.labelEXE.Name = "labelEXE";
            this.labelEXE.Size = new System.Drawing.Size(75, 13);
            this.labelEXE.TabIndex = 3;
            this.labelEXE.Text = "Minecraft EXE";
            // 
            // labelInstancePath
            // 
            this.labelInstancePath.AutoSize = true;
            this.labelInstancePath.Location = new System.Drawing.Point(12, 57);
            this.labelInstancePath.Name = "labelInstancePath";
            this.labelInstancePath.Size = new System.Drawing.Size(73, 13);
            this.labelInstancePath.TabIndex = 5;
            this.labelInstancePath.Text = "Instance Path";
            // 
            // textBoxInstance
            // 
            this.textBoxInstance.Location = new System.Drawing.Point(12, 73);
            this.textBoxInstance.Name = "textBoxInstance";
            this.textBoxInstance.Size = new System.Drawing.Size(191, 20);
            this.textBoxInstance.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "label3";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 156);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(191, 20);
            this.textBox3.TabIndex = 8;
            // 
            // labelAPIKey
            // 
            this.labelAPIKey.AutoSize = true;
            this.labelAPIKey.Location = new System.Drawing.Point(12, 98);
            this.labelAPIKey.Name = "labelAPIKey";
            this.labelAPIKey.Size = new System.Drawing.Size(45, 13);
            this.labelAPIKey.TabIndex = 7;
            this.labelAPIKey.Text = "API Key";
            // 
            // textBoxAPIKey
            // 
            this.textBoxAPIKey.Location = new System.Drawing.Point(12, 114);
            this.textBoxAPIKey.Name = "textBoxAPIKey";
            this.textBoxAPIKey.Size = new System.Drawing.Size(191, 20);
            this.textBoxAPIKey.TabIndex = 6;
            // 
            // FormConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 198);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.labelAPIKey);
            this.Controls.Add(this.textBoxAPIKey);
            this.Controls.Add(this.labelInstancePath);
            this.Controls.Add(this.textBoxInstance);
            this.Controls.Add(this.labelEXE);
            this.Controls.Add(this.textBoxEXE);
            this.Name = "FormConfiguration";
            this.Text = "Configuration";
            this.Load += new System.EventHandler(this.FormConfiguration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxEXE;
        private System.Windows.Forms.Label labelEXE;
        private System.Windows.Forms.Label labelInstancePath;
        private System.Windows.Forms.TextBox textBoxInstance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label labelAPIKey;
        private System.Windows.Forms.TextBox textBoxAPIKey;
    }
}