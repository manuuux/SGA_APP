using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Collections.Specialized;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTNIngresar_Click(object sender, EventArgs e)
        {
            if ((TXTID.Text == "" && TXTOS.Text == "")||(TXTID.Text=="ID"&&TXTOS.Text=="OS"))
            {
                MessageBox.Show("Debe ingresar un ID y una OS", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                using (var wb = new WebClient())
                {
                    var data = new NameValueCollection();
                    data["ID"] = TXTID.Text;
                    data["OS"] = TXTOS.Text;
                    var url = TXTURL.Text;
                    var response = wb.UploadValues(url, "POST", data);
                    string responseInString = Encoding.UTF8.GetString(response);
                    MessageBox.Show(Encoding.UTF8.GetString(response), "Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                TXTID.Text = "ID";TXTOS.Text = "OS";
            }
        }

        private void TXTID_Enter(object sender, EventArgs e)
        {
            if (TXTID.Text == "ID")
            {
                TXTID.Text = "";
            }
        }

        private void TXTOS_Enter(object sender, EventArgs e)
        {
            if (TXTOS.Text == "OS")
            {
                TXTOS.Text = "";
            }
        }

        private void TXTID_Leave(object sender, EventArgs e)
        {
            if (TXTID.Text == "") {
                TXTID.Text = "ID";
            }
        }

        private void TXTOS_Leave(object sender, EventArgs e)
        {
            if (TXTOS.Text == "")
            {
                TXTOS.Text = "OS";
            }
        }

        private void CHKExtras_CheckedChanged(object sender, EventArgs e)
        {
            if (CHKExtras.Checked)
            {
                this.Height = 220;
            }else
            {
                this.Height = 165;
            }
            
        }

        private void CHKAOT_CheckedChanged(object sender, EventArgs e)
        {
            if (CHKAOT.Checked)
            {
                this.TopMost=true;
            }else
            {
                this.TopMost = false;
            }

        }

        private void TXTURL_Enter(object sender, EventArgs e)
        {
            TXTURL.Text = "";
        }

        private void TXTURL_Leave(object sender, EventArgs e)
        {
            if (TXTURL.Text == "")
            {
                TXTURL.Text = "http://localhost/post/simplepost.php";
            }
        }
    }
}
