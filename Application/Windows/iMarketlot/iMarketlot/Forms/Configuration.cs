using iMarketlot.Forms;
using iMarketlot.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iMarketlot
{
    public partial class FormConfiguration : Form
    {
        public FormConfiguration()
        {
            InitializeComponent();
        }

        private void FormConfiguration_Load(object sender, EventArgs e)
        {

        }

        public void setEXEPath(String text)
        {
            textBoxEXE.Text = text;
        }

        public String getEXEPath()
        {
            return textBoxEXE.Text;
        }

        public void setInstancePath(String text)
        {
            textBoxInstance.Text = text;
        }

        public String getInstancePath()
        {
            return textBoxInstance.Text;
        }

        public void setAPIKey(String text)
        {
            textBoxAPIKey.Text = text;
        }

        public String getAPIKey()
        {
            return textBoxAPIKey.Text;
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            Configurator.saveParameters(this);
            this.Close();
        }

        private void buttonEXEPicker_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBoxEXE.Text = dialog.FileName;
            }
        }

        private void buttonInstancePicker_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK) 
            { 
                if(Configurator.checkIfCorrectInstanceFolder(dialog.SelectedPath))
                {
                textBoxInstance.Text = dialog.SelectedPath;
                } else
                {
                    FormError form = new FormError("Please pick a proper Minecraft Instance folder.");
                    form.ShowDialog();
                    buttonInstancePicker_Click(sender, e);
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            FormError form = new FormError("You clicked cancel. WHY!?!?!");
            form.ShowDialog();
        }
    }
}
