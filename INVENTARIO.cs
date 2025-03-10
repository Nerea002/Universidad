using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoDeVenta
{
    public partial class INVENTARIO : Form
    {
        int i = 1;
        int posicion;
        public INVENTARIO()
        {
            InitializeComponent();
            limpiar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Form = new Form1();
            Form.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string nombre, codigo, precio;

            nombre = textNom.Text;
            codigo = textCod.Text;
            precio = textPrecio.Text;
            dgInventario.Rows.Add(i + "", codigo, nombre, precio);
            i = i + 1;
            limpiar();
            textNom.Focus();
            
        }

        void limpiar()
        {
            btnMod.Enabled = true;
            btnEli.Enabled = true;
            textNom.Text = "";
            textCod.Text = "";
            textPrecio.Text = "";
        }

        private void dgInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = dgInventario.CurrentRow.Index;
            textCod.Text = dgInventario[2, posicion].Value.ToString();
            textNom.Text = dgInventario[3, posicion].Value.ToString();
            textPrecio.Text = dgInventario[4, posicion].Value.ToString();
            btnAdd.Enabled = false;
            btnMod.Enabled = true;
            btnEli.Enabled = true;
            textNom.Focus();
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            string nombre, codigo, precio;

            nombre = textNom.Text;
            codigo = textCod.Text;
            precio = textPrecio.Text;
            dgInventario[2, posicion].Value = textCod.Text;
            dgInventario[3, posicion].Value = textNom.Text;
            dgInventario[4, posicion].Value = textPrecio.Text;

            limpiar();
            textNom.Focus();
        }

        private void btnEli_Click(object sender, EventArgs e)
        {
            dgInventario.Rows.RemoveAt(posicion);
            textNom.Focus();
        }
    }
}
