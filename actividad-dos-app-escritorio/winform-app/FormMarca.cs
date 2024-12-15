using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace winform_app
{
    public partial class Marca : Form
    {
        public Marca()
        {
            InitializeComponent();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            string marca = textMarca.Text;
            listaMarca.Items.Add(marca);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string marcaDelete = textMarca.Text;



        }

        private void textMarca_TextChanged(object sender, EventArgs e)
        {

        }

        private void listaMarca_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
    }
}
