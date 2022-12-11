using iMarketlot.API;
using iMarketlot.Properties;
using iMarketlot.Utilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace iMarketlot
{
    public partial class FormiMarketlot : Form
    {
        public FormiMarketlot()
        {
            InitializeComponent();
        }
        private void FormiMarketlot_Load(object sender, EventArgs e)
        {
        }

        public void setLabelServerIPValue(IPAddress ipAddress)
        {
            rtbChatLog.Invoke(
                (Action)(
                    () => {
                        // Update the RichTextBox control
                        labelServerIPValue.Text = ipAddress.ToString();
                    }
                )
            );
        }

        public void setRTBChatLogText(List<String> lines)
        {
            rtbChatLog.Invoke(
                (Action)(
                    () => {
                        // Update the RichTextBox control
                        rtbChatLog.Lines = lines.ToArray();
                    }
                )
            );
        }
        
        public void setPictureboxServerStatus(Boolean status)
        {
            pictureboxServerStatus.Invoke(
                (Action)(
                    () => {
                        // Update the RichTextBox control
                        if(status)
                        {
                            pictureboxServerStatus.BackColor = Color.Green;
                        } else
                        {
                            pictureboxServerStatus.BackColor = Color.Red;
                        }
                    }
                )
            );
        }

        private void configToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Configurator.run(true);
        }
    }
}
