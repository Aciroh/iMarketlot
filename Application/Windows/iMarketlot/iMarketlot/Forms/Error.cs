using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iMarketlot.Forms
{
    public partial class FormError : Form
    {
        public FormError(String errorMessage)
        {
            InitializeComponent();
            richTextBoxErrorMessage.Text = errorMessage;
        }

        private void FormError_Load(object sender, EventArgs eventArgs)
        {
            
        }

        private void buttonOhSnap_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
