﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_app
{
    public partial class FormCategoria : Form
    {
        public FormCategoria()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string agregar = textCategoria.Text;
            listaCategoria.Items.Add(agregar);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FormCategoria_Load(object sender, EventArgs e)
        {

        }
    }
}
