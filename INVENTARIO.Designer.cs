namespace PuntoDeVenta
{
    partial class INVENTARIO
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(INVENTARIO));
            this.button4 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEli = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.dgInventario = new System.Windows.Forms.DataGridView();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Val = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textPrecio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textNom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textCod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.puntoDeVentaDataSet = new PuntoDeVenta.PuntoDeVentaDataSet();
            this.puntoDeVentaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgInventario)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.puntoDeVentaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.puntoDeVentaDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("BankGothic Md BT", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button4.Location = new System.Drawing.Point(12, 12);
            this.button4.Name = "button4";
            this.button4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button4.Size = new System.Drawing.Size(142, 30);
            this.button4.TabIndex = 16;
            this.button4.Text = "Volver";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("BankGothic Md BT", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnAdd.Location = new System.Drawing.Point(815, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAdd.Size = new System.Drawing.Size(155, 33);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEli
            // 
            this.btnEli.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEli.BackgroundImage")));
            this.btnEli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEli.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnEli.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEli.Font = new System.Drawing.Font("BankGothic Md BT", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEli.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnEli.Location = new System.Drawing.Point(976, 12);
            this.btnEli.Name = "btnEli";
            this.btnEli.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnEli.Size = new System.Drawing.Size(155, 33);
            this.btnEli.TabIndex = 18;
            this.btnEli.Text = "Eliminar";
            this.btnEli.UseVisualStyleBackColor = true;
            this.btnEli.Click += new System.EventHandler(this.btnEli_Click);
            // 
            // btnMod
            // 
            this.btnMod.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMod.BackgroundImage")));
            this.btnMod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMod.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnMod.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMod.Font = new System.Drawing.Font("BankGothic Md BT", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMod.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnMod.Location = new System.Drawing.Point(1137, 11);
            this.btnMod.Name = "btnMod";
            this.btnMod.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnMod.Size = new System.Drawing.Size(155, 33);
            this.btnMod.TabIndex = 19;
            this.btnMod.Text = "Modificar";
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // dgInventario
            // 
            this.dgInventario.AllowUserToOrderColumns = true;
            this.dgInventario.AutoGenerateColumns = false;
            this.dgInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInventario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Num,
            this.cod,
            this.NomProd,
            this.Val});
            this.dgInventario.DataSource = this.puntoDeVentaDataSetBindingSource;
            this.dgInventario.Location = new System.Drawing.Point(12, 148);
            this.dgInventario.Name = "dgInventario";
            this.dgInventario.Size = new System.Drawing.Size(1280, 373);
            this.dgInventario.TabIndex = 20;
            this.dgInventario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgInventario_CellContentClick);
            // 
            // Num
            // 
            this.Num.HeaderText = "Numeración";
            this.Num.Name = "Num";
            // 
            // cod
            // 
            this.cod.HeaderText = "Código";
            this.cod.MaxInputLength = 32;
            this.cod.Name = "cod";
            this.cod.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cod.Width = 500;
            // 
            // NomProd
            // 
            this.NomProd.HeaderText = "Nombre del Prdocuto";
            this.NomProd.Name = "NomProd";
            this.NomProd.Width = 500;
            // 
            // Val
            // 
            this.Val.HeaderText = "Valor";
            this.Val.Name = "Val";
            this.Val.Width = 150;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textPrecio);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textNom);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textCod);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Dutch801 XBd BT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Salmon;
            this.groupBox2.Location = new System.Drawing.Point(12, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(1280, 91);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos";
            // 
            // textPrecio
            // 
            this.textPrecio.Location = new System.Drawing.Point(995, 43);
            this.textPrecio.Name = "textPrecio";
            this.textPrecio.Size = new System.Drawing.Size(225, 27);
            this.textPrecio.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(991, 20);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(61, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Precio";
            // 
            // textNom
            // 
            this.textNom.Location = new System.Drawing.Point(514, 42);
            this.textNom.Name = "textNom";
            this.textNom.Size = new System.Drawing.Size(453, 27);
            this.textNom.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(510, 20);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(177, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre del articulo";
            // 
            // textCod
            // 
            this.textCod.Location = new System.Drawing.Point(22, 43);
            this.textCod.MaxLength = 32;
            this.textCod.Name = "textCod";
            this.textCod.Size = new System.Drawing.Size(453, 27);
            this.textCod.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(171, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código del articulo";
            // 
            // puntoDeVentaDataSet
            // 
            this.puntoDeVentaDataSet.DataSetName = "PuntoDeVentaDataSet";
            this.puntoDeVentaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // puntoDeVentaDataSetBindingSource
            // 
            this.puntoDeVentaDataSetBindingSource.DataSource = this.puntoDeVentaDataSet;
            this.puntoDeVentaDataSetBindingSource.Position = 0;
            // 
            // INVENTARIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1304, 533);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgInventario);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.btnEli);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.button4);
            this.Name = "INVENTARIO";
            this.Text = "INVENTARIO";
            ((System.ComponentModel.ISupportInitialize)(this.dgInventario)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.puntoDeVentaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.puntoDeVentaDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEli;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.DataGridView dgInventario;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textPrecio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textNom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textCod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Val;
        private System.Windows.Forms.BindingSource puntoDeVentaDataSetBindingSource;
        private PuntoDeVentaDataSet puntoDeVentaDataSet;
    }
}