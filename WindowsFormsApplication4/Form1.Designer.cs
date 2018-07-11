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
            this.BTNIngresar = new System.Windows.Forms.Button();
            this.TXTID = new System.Windows.Forms.TextBox();
            this.TXTOS = new System.Windows.Forms.TextBox();
            this.CHKAOT = new System.Windows.Forms.CheckBox();
            this.TXTURL = new System.Windows.Forms.TextBox();
            this.CHKExtras = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // BTNIngresar
            // 
            this.BTNIngresar.Location = new System.Drawing.Point(12, 63);
            this.BTNIngresar.Name = "BTNIngresar";
            this.BTNIngresar.Size = new System.Drawing.Size(100, 23);
            this.BTNIngresar.TabIndex = 0;
            this.BTNIngresar.Text = "Ingresar";
            this.BTNIngresar.UseVisualStyleBackColor = true;
            this.BTNIngresar.Click += new System.EventHandler(this.BTNIngresar_Click);
            // 
            // TXTID
            // 
            this.TXTID.Location = new System.Drawing.Point(12, 11);
            this.TXTID.Name = "TXTID";
            this.TXTID.Size = new System.Drawing.Size(100, 20);
            this.TXTID.TabIndex = 1;
            this.TXTID.Text = "ID";
            this.TXTID.Enter += new System.EventHandler(this.TXTID_Enter);
            this.TXTID.Leave += new System.EventHandler(this.TXTID_Leave);
            // 
            // TXTOS
            // 
            this.TXTOS.Location = new System.Drawing.Point(12, 37);
            this.TXTOS.Name = "TXTOS";
            this.TXTOS.Size = new System.Drawing.Size(100, 20);
            this.TXTOS.TabIndex = 2;
            this.TXTOS.Text = "OS";
            this.TXTOS.Enter += new System.EventHandler(this.TXTOS_Enter);
            this.TXTOS.Leave += new System.EventHandler(this.TXTOS_Leave);
            // 
            // CHKAOT
            // 
            this.CHKAOT.AutoSize = true;
            this.CHKAOT.Location = new System.Drawing.Point(12, 156);
            this.CHKAOT.Name = "CHKAOT";
            this.CHKAOT.Size = new System.Drawing.Size(97, 17);
            this.CHKAOT.TabIndex = 3;
            this.CHKAOT.Text = "Siempre Visible";
            this.CHKAOT.UseVisualStyleBackColor = true;
            this.CHKAOT.CheckedChanged += new System.EventHandler(this.CHKAOT_CheckedChanged);
            // 
            // TXTURL
            // 
            this.TXTURL.Location = new System.Drawing.Point(12, 130);
            this.TXTURL.Name = "TXTURL";
            this.TXTURL.Size = new System.Drawing.Size(100, 20);
            this.TXTURL.TabIndex = 4;
            this.TXTURL.Text = "http://localhost/post/simplepost.php";
            this.TXTURL.Enter += new System.EventHandler(this.TXTURL_Enter);
            this.TXTURL.Leave += new System.EventHandler(this.TXTURL_Leave);
            // 
            // CHKExtras
            // 
            this.CHKExtras.AutoSize = true;
            this.CHKExtras.Location = new System.Drawing.Point(12, 99);
            this.CHKExtras.Name = "CHKExtras";
            this.CHKExtras.Size = new System.Drawing.Size(55, 17);
            this.CHKExtras.TabIndex = 6;
            this.CHKExtras.Text = "Extras";
            this.CHKExtras.UseVisualStyleBackColor = true;
            this.CHKExtras.CheckedChanged += new System.EventHandler(this.CHKExtras_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(123, 126);
            this.Controls.Add(this.CHKExtras);
            this.Controls.Add(this.TXTURL);
            this.Controls.Add(this.CHKAOT);
            this.Controls.Add(this.TXTOS);
            this.Controls.Add(this.TXTID);
            this.Controls.Add(this.BTNIngresar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNIngresar;
        private System.Windows.Forms.TextBox TXTID;
        private System.Windows.Forms.TextBox TXTOS;
        private System.Windows.Forms.CheckBox CHKAOT;
        private System.Windows.Forms.TextBox TXTURL;
        private System.Windows.Forms.CheckBox CHKExtras;
    }
}

