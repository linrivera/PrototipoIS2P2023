﻿using System;
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

        CapaControlador_Alumnos.CpControlador controlador = new CapaControlador_Alumnos.CpControlador();

        void displayDatos()
        {
            DataTable data = controlador.MostrarReportes();
            dataGridView1.DataSource = data;
            dataGridView1.Columns[0].HeaderText = "Carnet";
            dataGridView1.Columns[1].HeaderText = "Nombre";
            dataGridView1.Columns[2].HeaderText = "Direccion";
            dataGridView1.Columns[3].HeaderText = "Telefono";
            dataGridView1.Columns[4].HeaderText = "Correo";
            dataGridView1.Columns[5].HeaderText = "Estatus";
        }

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
