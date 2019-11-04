﻿using CacaoTech.BLL;
using CacaoTech.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CacaoTech.UI.Registros
{
    public partial class rDeposito : Form
    {
        GenericaBLL<Vendedores> genericaVendedorBLL;
        GenericaBLL<Cacao> genericaCacaoBLL;
        public rDeposito()
        {
            genericaVendedorBLL = new GenericaBLL<Vendedores>();
            genericaCacaoBLL = new GenericaBLL<Cacao>();
            InitializeComponent();
            LlenarCombos();
        }

        public void LlenarCombos()
        {
            //Llenando combobox de tipos de cacao
            TipoCacaocomboBox.DataSource = null;
            List<Cacao> lista1 = genericaCacaoBLL.GetList(p => true);
            TipoCacaocomboBox.DataSource = lista1;
            TipoCacaocomboBox.DisplayMember = "Tipo";
            TipoCacaocomboBox.ValueMember = "CacaoID";


            //Llenando combobox de vendedores
            VendedorescomboBox.DataSource = null;
            List<Vendedores> lista = genericaVendedorBLL.GetList(p => true);
            VendedorescomboBox.DataSource = lista;
            VendedorescomboBox.DisplayMember = "Nombre";
            VendedorescomboBox.ValueMember = "VendedorID";

            
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {

        }

        private void AgregarDepositobutton_Click(object sender, EventArgs e)
        {

        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {

        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {

        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {

        }

        private void rDeposito_Load(object sender, EventArgs e)
        {
            LlenarCombos();
        }
    }
}
