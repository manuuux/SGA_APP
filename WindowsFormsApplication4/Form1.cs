﻿using System;
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
        string SGAURL = "http://172.27.44.23/include/actOS.php";
        //Parametros para maximizar y minimizar a travez del click la barra de tareas
        const int WS_MINIMIZEBOX = 0x20000;
        const int CS_DBLCLKS = 0x8;
        public Form1()
        {
            InitializeComponent();
            this.Text = "SGA APP";
        }
        //funcion para maximizar y minimizar a travez del click la barra de tareas
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= WS_MINIMIZEBOX;
                cp.ClassStyle |= CS_DBLCLKS;
                return cp;
            }
        }
        private void lblmsg(string msg,int style)
        {
            LBLMSG.Text = msg;
            if (style == 1) { LBLMSG.BackColor = Color.FromArgb(216, 32, 32); }
            if (style == 2) { LBLMSG.BackColor = Color.FromArgb(149, 198, 56); }
            if (style == 3) { LBLMSG.BackColor = Color.FromArgb(216, 216, 64); }
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
                    data["id_bitacora"] = new String(TXTID.Text.Where(Char.IsDigit).ToArray()); 
                    data["num_os_new"] = new String(TXTOS.Text.Where(Char.IsDigit).ToArray()); 
                    data["num_os_old"] = "0";
                    var url = SGAURL;
                    try
                    {
                        var response = wb.UploadValues(url, "POST", data);
                        string responseInString = Encoding.UTF8.GetString(response);
                        lblmsg("Datos ingresados", 2);
                    }
                    catch (System.Net.WebException o)
                    {
                        lblmsg("Error al conectarse", 1);
                    }
                    
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
    

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BTNExtras_Click(object sender, EventArgs e)
        {
            if (this.Height == 140)
            {
                BTNExtras.Text = "▲";
                this.Height = 253;
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
                        var url = SGAURL;
                        var response = wb.UploadValues(url, "POST", data);
                        string responseInString = Encoding.UTF8.GetString(response);
                        lblmsg("Datos ingresados", 2);
                    }
                }
                
            }
        }

        private void CHKTrans_CheckedChanged(object sender, EventArgs e)
        {
            if (CHKTrans.Checked)
            {
                this.Opacity = .90;
            }else
            {

                this.Opacity = 1;
            }
        }

        private void BTNAcerca_Click(object sender, EventArgs e)
        {
            var Acerca = new SGAAPP.Acerca();
            Acerca.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
