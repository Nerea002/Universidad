using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PuntoDeVenta
{
    public partial class Ticket : Form
    {
        public Ticket()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
          

class PuntoDeVenta
        {
            static void GenerarTicket(string[] productos, int[] cantidad, double[] precios)
            {
                string ticketPath = "ticket.txt";
                using (StreamWriter sw = new StreamWriter(ticketPath))
                {
                    sw.WriteLine("================================");
                    for (int i = 0; i < productos.Length; i++)
                    {
                        string linea = string.Format("{0,-20} {1,3} x {2,6:F2}", productos[i], cantidad[i], precios[i]);
                        sw.WriteLine(linea.Length > 32 ? linea.Substring(0, 32) : linea);
                    }
                    sw.WriteLine("================================");
                    sw.WriteLine("       Final del ticket.");
                }
                Console.WriteLine("Ticket generado correctamente.");
            }

            static void ImprimirTicket()
            {
                ProcessStartInfo psi = new ProcessStartInfo("notepad.exe", "ticket.txt")
                {
                    UseShellExecute = true
                };
                Process.Start(psi);
            }
        }

    }
}

