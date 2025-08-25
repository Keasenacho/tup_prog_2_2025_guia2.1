using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia2._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DepartamentoVehicular departamentovehicular;
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Desea Registrar el Vehiculo?", "Registrar", MessageBoxButtons.YesNo);

            if (respuesta == DialogResult.Yes)
            {
               
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
      Form1 Listar = new Form1();
            for (int i = 0; i < departamentovehicular.CantidadRegistros; i++)
            {
                Listar.lb1.Items.Add(departamentovehicular.VerRegistro(i).VerDetalle());
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Lista ListaPersonas = new Lista();
            if (ListaPersonas.ShowDialog() == DialogResult.OK)
            {
                int dni = Convert.ToInt32(ListaPersonas.tbDni.Text);
                string nombre = ListaPersonas.tbNombre.Text;
            }

            ListaPersonas.Dispose();

        }
    }
}

