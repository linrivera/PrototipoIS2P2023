using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador_Alumnos; 

namespace CapaVista
{
    public partial class Alumnos : Form
    {
        public Alumnos()
        {
            InitializeComponent();
        }

        CapaControlador_Alumnos.controlador controlador = new CapaControlador_Alumnos.controlador ();

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            //NavegadorVista.Navegador.idApp = "8002";
            //TextBox[] Grupotextbox = { textIDCuenta, textTCuenta, textNombreCuenta, textCargo, textAbono, textSaldo, textStatus };
            //TextBox[] Idtextbox = { textIDCuenta, textTCuenta };
            //navegador_ctas.textbox = Grupotextbox;
            //navegador_ctas.tabla = dgvCuentasM;
            //navegador_ctas.textboxi = Idtextbox;
            //navegador_ctas.actual = this;
            //navegador_ctas.cargar(dgvCuentasM, Grupotextbox, "colchoneria");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TextBox[] arrayTexBox = { textBox15, textBox14, textBox13, textBox12, textBox11, textBox10 };
            controlador.ast(arrayTexBox, "insert");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TextBox[] arrayTexBox = { textBox15, textBox14, textBox13, textBox12, textBox11, textBox10 };
            controlador.ast(arrayTexBox, "update");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TextBox[] arrayTexBox = { textBox15, textBox14, textBox13, textBox12, textBox11, textBox10 };
            controlador.ast(arrayTexBox, "delete");
        }
    }
}
