namespace PuntoDeVenta
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contra = new System.Windows.Forms.Label();
            this.usuario = new System.Windows.Forms.Label();
            this.acceder_btn = new System.Windows.Forms.Button();
            this.cerrar_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FloralWhite;
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.contra);
            this.groupBox1.Controls.Add(this.usuario);
            this.groupBox1.Font = new System.Drawing.Font("BankGothic Md BT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Chocolate;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(537, 297);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INGRESAR";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox2.Location = new System.Drawing.Point(74, 204);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(366, 24);
            this.textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Location = new System.Drawing.Point(74, 97);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(366, 24);
            this.textBox1.TabIndex = 2;
            // 
            // contra
            // 
            this.contra.AutoSize = true;
            this.contra.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contra.Location = new System.Drawing.Point(36, 166);
            this.contra.Name = "contra";
            this.contra.Size = new System.Drawing.Size(104, 17);
            this.contra.TabIndex = 1;
            this.contra.Text = "Contraseña:";
            // 
            // usuario
            // 
            this.usuario.AutoSize = true;
            this.usuario.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuario.Location = new System.Drawing.Point(36, 59);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(75, 17);
            this.usuario.TabIndex = 0;
            this.usuario.Text = "Usuario:";
            this.usuario.Click += new System.EventHandler(this.label1_Click);
            // 
            // acceder_btn
            // 
            this.acceder_btn.BackColor = System.Drawing.Color.SaddleBrown;
            this.acceder_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("acceder_btn.BackgroundImage")));
            this.acceder_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.acceder_btn.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acceder_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.acceder_btn.Location = new System.Drawing.Point(416, 342);
            this.acceder_btn.Name = "acceder_btn";
            this.acceder_btn.Size = new System.Drawing.Size(133, 29);
            this.acceder_btn.TabIndex = 1;
            this.acceder_btn.Text = "Acceder";
            this.acceder_btn.UseVisualStyleBackColor = false;
            this.acceder_btn.Click += new System.EventHandler(this.acceder_btn_Click);
            // 
            // cerrar_btn
            // 
            this.cerrar_btn.BackColor = System.Drawing.Color.SaddleBrown;
            this.cerrar_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cerrar_btn.BackgroundImage")));
            this.cerrar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cerrar_btn.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cerrar_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cerrar_btn.Location = new System.Drawing.Point(268, 342);
            this.cerrar_btn.Name = "cerrar_btn";
            this.cerrar_btn.Size = new System.Drawing.Size(133, 29);
            this.cerrar_btn.TabIndex = 2;
            this.cerrar_btn.Text = "Cerrar";
            this.cerrar_btn.UseVisualStyleBackColor = false;
            this.cerrar_btn.Click += new System.EventHandler(this.cerrar_btn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(561, 392);
            this.Controls.Add(this.cerrar_btn);
            this.Controls.Add(this.acceder_btn);
            this.Controls.Add(this.groupBox1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label usuario;
        private System.Windows.Forms.Label contra;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button acceder_btn;
        private System.Windows.Forms.Button cerrar_btn;
    }
}