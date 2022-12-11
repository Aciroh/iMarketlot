namespace iMarketlot.Forms
{
    partial class FormError
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
            this.richTextBoxErrorMessage = new System.Windows.Forms.RichTextBox();
            this.buttonOhSnap = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBoxErrorMessage
            // 
            this.richTextBoxErrorMessage.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBoxErrorMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxErrorMessage.Location = new System.Drawing.Point(12, 12);
            this.richTextBoxErrorMessage.Name = "richTextBoxErrorMessage";
            this.richTextBoxErrorMessage.Size = new System.Drawing.Size(301, 96);
            this.richTextBoxErrorMessage.TabIndex = 0;
            this.richTextBoxErrorMessage.Text = "";
            // 
            // buttonOhSnap
            // 
            this.buttonOhSnap.Location = new System.Drawing.Point(185, 139);
            this.buttonOhSnap.Name = "buttonOhSnap";
            this.buttonOhSnap.Size = new System.Drawing.Size(75, 23);
            this.buttonOhSnap.TabIndex = 1;
            this.buttonOhSnap.Text = "Oh Snap!";
            this.buttonOhSnap.UseVisualStyleBackColor = true;
            this.buttonOhSnap.Click += new System.EventHandler(this.buttonOhSnap_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(72, 139);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 174);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOhSnap);
            this.Controls.Add(this.richTextBoxErrorMessage);
            this.Name = "FormError";
            this.Text = "Error!";
            this.Load += new System.EventHandler(this.FormError_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxErrorMessage;
        private System.Windows.Forms.Button buttonOhSnap;
        private System.Windows.Forms.Button buttonCancel;
    }
}