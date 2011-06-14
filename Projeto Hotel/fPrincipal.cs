﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Projeto_Hotel
{
    public partial class fPrincipal : Form
    {
        public fPrincipal()
        {
            InitializeComponent();

            //BKM Código para teste da form. RETIRAR
            fConsultarFuncionario f = new fConsultarFuncionario();
            //fCadastrarFuncionario f = new fCadastrarFuncionario();
            f.ShowDialog(this);
        }

        public static string STRING_CONEXAO = @"Data Source=.\SQLEXPRESS; Initial Catalog = banco_hotel; Integrated Security = SSPI";

        // Menu CADASTRO
        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fCadastrarCliente form = new fCadastrarCliente(this);
            form.ShowDialog();
        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fCadastrarFuncionario form = new fCadastrarFuncionario();
            form.ShowDialog(this);
        }

        private void quartoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fCadastrarQuarto form = new fCadastrarQuarto();
            form.ShowDialog(this);
        }


        // Menu CONSULTAR
        private void estadiaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fConsultarEstadia form = new fConsultarEstadia();
            form.ShowDialog(this);
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fConsultarCliente form = new fConsultarCliente();
            form.ShowDialog(this);
        }

        private void quartoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fConsultarQuarto form = new fConsultarQuarto();
            form.ShowDialog(this);
        }

        private void funcionarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fConsultarFuncionario form = new fConsultarFuncionario();
            form.ShowDialog(this);
        }


        // Menu ESTADIA
        private void estadiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fEstadia form = new fEstadia();
            form.ShowDialog(this);
        }


        
       

    }
}
