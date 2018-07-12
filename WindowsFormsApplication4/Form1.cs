using System;
using System.IO;
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
        private void lblmsg(string msg,int style)
        {
            LBLMSG.Text = msg;
            if (style == 1) { LBLMSG.BackColor = Color.Red; }
            if (style == 2) { LBLMSG.BackColor = Color.Green; }
            if (style == 3) { LBLMSG.BackColor = Color.Yellow; }
            var t = new Timer();
            t.Interval = 1500; 
            t.Tick += (s, e) =>
            {
                LBLMSG.Text="";
                LBLMSG.BackColor = Color.Transparent;
                t.Stop();
            };
            t.Start();
        }
        private void BTNIngresar_Click(object sender, EventArgs e)
        {
            if ((TXTID.Text == "" && TXTOS.Text == "")||(TXTID.Text=="ID"&&TXTOS.Text=="OS"))
            {
                lblmsg("Ingrese ID y OS",1);
            }
            else
            {
                using (var wb = new WebClient())
                {
                    var data = new NameValueCollection();
                    data["id_bitacora"] = TXTID.Text;
                    data["num_os_new"] = TXTOS.Text;
                    data["num_os_old"] = "0";
                    var url = TXTURL.Text;
                    var response = wb.UploadValues(url, "POST", data);
                    string responseInString = Encoding.UTF8.GetString(response);
                    lblmsg("Datos ingresados",2);
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
            TXTID.BackColor = Color.FromArgb(35, 91, 121);
        }

        private void TXTOS_Enter(object sender, EventArgs e)
        {
            if (TXTOS.Text == "OS")
            {
                TXTOS.Text = "";
            }
            TXTOS.BackColor = Color.FromArgb(35, 91, 121);
        }

        private void TXTID_Leave(object sender, EventArgs e)
        {
            if (TXTID.Text == "") {
                TXTID.Text = "ID";
            }
            TXTID.BackColor = Color.FromArgb(70, 129, 160);
        }

        private void TXTOS_Leave(object sender, EventArgs e)
        {
            if (TXTOS.Text == "")
            {
                TXTOS.Text = "OS";
            }
            TXTOS.BackColor = Color.FromArgb(70, 129, 160);
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }
            base.WndProc(ref m);
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

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BTNExtras_Click(object sender, EventArgs e)
        {
            if (this.Height == 140)
            {
                BTNExtras.Text = "▲";
                this.Height = 265;
            }else
            {
                BTNExtras.Text = "▼";
                this.Height = 140;
            }
        }
        string pathToFile = "";
        private void BTNMasiva_Click(object sender, EventArgs e)
        {
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open Text File";
            theDialog.Filter = "CSV files|*.csv";
            theDialog.InitialDirectory = @"%USERPROFILE%\Desktop";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(theDialog.FileName.ToString());
                pathToFile = theDialog.FileName;//doesn't need .tostring because .filename returns a string// saves the location of the selected object

            }

            if (File.Exists(pathToFile))// only executes if the file at pathtofile exists//you need to add the using System.IO reference at the top of te code to use this
            {
                //method1
                var lines = File.ReadLines(pathToFile);

                foreach (string line in lines)
                {
                    string[] datos = line.Split(';');
                    using (var wb = new WebClient())
                    {
                        var data = new NameValueCollection();
                        data["id_bitacora"] = datos[0];
                        data["num_os_new"] = datos[1];
                        data["num_os_old"] = "0";
                        var url = TXTURL.Text;
                        var response = wb.UploadValues(url, "POST", data);
                        string responseInString = Encoding.UTF8.GetString(response);
                        lblmsg("Datos ingresados", 2);
                    }
                }
                
            }
        }
    }
}
