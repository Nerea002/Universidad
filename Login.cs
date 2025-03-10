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
    public partial class Login : Form
    {
        string user = "Negocio";
        string contraseña = "11223344";
        public Login()
        {
            InitializeComponent();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void acceder_btn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != user && textBox2.Text != contraseña)
            {
                if (textBox1.Text != user)
                {
                    MessageBox.Show("Usuario Incorrecto");
                    textBox1.Clear();
                    textBox2.Focus();
                    return;
                }
                if (textBox2.Text != contraseña)
                {
                    MessageBox.Show("Contraseña Incorrecta");
                    textBox2.Clear();
                    textBox2.Focus();
                    return;
                }
            }
            else
            {
                textBox1.Clear();
                textBox2.Clear();
                this.Hide();
                Form1 Form = new Form1();
                Form.ShowDialog();

            }

        }

        private void cerrar_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
