namespace WindowsFormsApplication4
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BTNIngresar = new System.Windows.Forms.Button();
            this.TXTID = new System.Windows.Forms.TextBox();
            this.TXTOS = new System.Windows.Forms.TextBox();
            this.CHKAOT = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BTNExtras = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LBLMSG = new System.Windows.Forms.Label();
            this.BTNMasiva = new System.Windows.Forms.Button();
            this.DLGAbrirArchivo = new System.Windows.Forms.OpenFileDialog();
            this.BTNAcerca = new System.Windows.Forms.Button();
            this.CHKTrans = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTNIngresar
            // 
            this.BTNIngresar.FlatAppearance.BorderSize = 0;
            this.BTNIngresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(154)))), ((int)(((byte)(87)))));
            this.BTNIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNIngresar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNIngresar.Location = new System.Drawing.Point(-6, 95);
            this.BTNIngresar.Name = "BTNIngresar";
            this.BTNIngresar.Size = new System.Drawing.Size(148, 23);
            this.BTNIngresar.TabIndex = 3;
            this.BTNIngresar.Text = "INGRESAR";
            this.BTNIngresar.UseVisualStyleBackColor = true;
            this.BTNIngresar.Click += new System.EventHandler(this.BTNIngresar_Click);
            // 
            // TXTID
            // 
            this.TXTID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(129)))), ((int)(((byte)(160)))));
            this.TXTID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXTID.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTID.Location = new System.Drawing.Point(9, 30);
            this.TXTID.Name = "TXTID";
            this.TXTID.Size = new System.Drawing.Size(119, 18);
            this.TXTID.TabIndex = 1;
            this.TXTID.Text = "ID";
            this.TXTID.Enter += new System.EventHandler(this.TXTID_Enter);
            this.TXTID.Leave += new System.EventHandler(this.TXTID_Leave);
            // 
            // TXTOS
            // 
            this.TXTOS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(129)))), ((int)(((byte)(160)))));
            this.TXTOS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXTOS.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTOS.Location = new System.Drawing.Point(9, 56);
            this.TXTOS.Name = "TXTOS";
            this.TXTOS.Size = new System.Drawing.Size(119, 18);
            this.TXTOS.TabIndex = 2;
            this.TXTOS.Text = "OS";
            this.TXTOS.Enter += new System.EventHandler(this.TXTOS_Enter);
            this.TXTOS.Leave += new System.EventHandler(this.TXTOS_Leave);
            // 
            // CHKAOT
            // 
            this.CHKAOT.AutoSize = true;
            this.CHKAOT.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHKAOT.Location = new System.Drawing.Point(16, 145);
            this.CHKAOT.Name = "CHKAOT";
            this.CHKAOT.Size = new System.Drawing.Size(104, 17);
            this.CHKAOT.TabIndex = 100;
            this.CHKAOT.Text = "Siempre Visible";
            this.CHKAOT.UseVisualStyleBackColor = true;
            this.CHKAOT.CheckedChanged += new System.EventHandler(this.CHKAOT_CheckedChanged);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(154)))), ((int)(((byte)(87)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(116, -2);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(20, 20);
            this.button1.TabIndex = 7;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTNExtras
            // 
            this.BTNExtras.FlatAppearance.BorderSize = 0;
            this.BTNExtras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(154)))), ((int)(((byte)(87)))));
            this.BTNExtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNExtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNExtras.Location = new System.Drawing.Point(-4, 121);
            this.BTNExtras.Name = "BTNExtras";
            this.BTNExtras.Size = new System.Drawing.Size(146, 18);
            this.BTNExtras.TabIndex = 0;
            this.BTNExtras.Text = "▼";
            this.BTNExtras.UseVisualStyleBackColor = true;
            this.BTNExtras.Click += new System.EventHandler(this.BTNExtras_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "SGA APP";
            // 
            // LBLMSG
            // 
            this.LBLMSG.Font = new System.Drawing.Font("Segoe UI Semibold", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLMSG.Location = new System.Drawing.Point(-4, 77);
            this.LBLMSG.Name = "LBLMSG";
            this.LBLMSG.Size = new System.Drawing.Size(146, 15);
            this.LBLMSG.TabIndex = 10;
            this.LBLMSG.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BTNMasiva
            // 
            this.BTNMasiva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(154)))), ((int)(((byte)(87)))));
            this.BTNMasiva.FlatAppearance.BorderSize = 0;
            this.BTNMasiva.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(129)))), ((int)(((byte)(160)))));
            this.BTNMasiva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNMasiva.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNMasiva.Location = new System.Drawing.Point(-6, 191);
            this.BTNMasiva.Name = "BTNMasiva";
            this.BTNMasiva.Size = new System.Drawing.Size(148, 27);
            this.BTNMasiva.TabIndex = 101;
            this.BTNMasiva.Text = "Masiva";
            this.BTNMasiva.UseVisualStyleBackColor = false;
            this.BTNMasiva.Click += new System.EventHandler(this.BTNMasiva_Click);
            // 
            // DLGAbrirArchivo
            // 
            this.DLGAbrirArchivo.FileName = "openFileDialog1";
            // 
            // BTNAcerca
            // 
            this.BTNAcerca.FlatAppearance.BorderSize = 0;
            this.BTNAcerca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNAcerca.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNAcerca.Location = new System.Drawing.Point(-6, 224);
            this.BTNAcerca.Name = "BTNAcerca";
            this.BTNAcerca.Size = new System.Drawing.Size(149, 28);
            this.BTNAcerca.TabIndex = 112;
            this.BTNAcerca.Text = "Acerca de...";
            this.BTNAcerca.UseVisualStyleBackColor = true;
            this.BTNAcerca.Click += new System.EventHandler(this.BTNAcerca_Click);
            // 
            // CHKTrans
            // 
            this.CHKTrans.AutoSize = true;
            this.CHKTrans.Checked = true;
            this.CHKTrans.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CHKTrans.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHKTrans.Location = new System.Drawing.Point(16, 168);
            this.CHKTrans.Name = "CHKTrans";
            this.CHKTrans.Size = new System.Drawing.Size(96, 17);
            this.CHKTrans.TabIndex = 113;
            this.CHKTrans.Text = "Transparencia";
            this.CHKTrans.UseVisualStyleBackColor = true;
            this.CHKTrans.CheckedChanged += new System.EventHandler(this.CHKTrans_CheckedChanged);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(154)))), ((int)(((byte)(87)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(97, -4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(20, 23);
            this.button2.TabIndex = 114;
            this.button2.Text = "_";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.BTNIngresar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(129)))), ((int)(((byte)(160)))));
            this.ClientSize = new System.Drawing.Size(135, 140);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.CHKTrans);
            this.Controls.Add(this.BTNAcerca);
            this.Controls.Add(this.BTNMasiva);
            this.Controls.Add(this.LBLMSG);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTNExtras);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CHKAOT);
            this.Controls.Add(this.TXTOS);
            this.Controls.Add(this.TXTID);
            this.Controls.Add(this.BTNIngresar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNIngresar;
        private System.Windows.Forms.TextBox TXTID;
        private System.Windows.Forms.TextBox TXTOS;
        private System.Windows.Forms.CheckBox CHKAOT;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BTNExtras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LBLMSG;
        private System.Windows.Forms.Button BTNMasiva;
        private System.Windows.Forms.OpenFileDialog DLGAbrirArchivo;
        private System.Windows.Forms.Button BTNAcerca;
        private System.Windows.Forms.CheckBox CHKTrans;
        private System.Windows.Forms.Button button2;
    }
}

