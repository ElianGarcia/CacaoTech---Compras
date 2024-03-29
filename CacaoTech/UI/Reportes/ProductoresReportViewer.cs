﻿using CacaoTech.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CacaoTech.UI.Reportes
{
    public partial class ProductoresReportViewer : Form
    {
        private List<Productores> ListaProductores;
        public ProductoresReportViewer(List<Productores> productores)
        {
            this.ListaProductores = productores;
            InitializeComponent();
        }

        private void cProductores_Load(object sender, EventArgs e)
        {
            ListProductores productoresCrystalReport = new ListProductores();
            productoresCrystalReport.SetDataSource(ListaProductores);

            crystalReportViewer1.ReportSource = productoresCrystalReport;
            productoresCrystalReport.Refresh();
        }
    }
}
