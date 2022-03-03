using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1_tarea_03_typevar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bttn_mostrar_Click(object sender, EventArgs e)
        {
            txtBx_salida.Text = "";
            txtBx_salida.AppendText("---Tipos de variables---\r\nuint \r\nint \r\nsbyte \r\ndecimal \r\ndouble \r\nfloat \r\nlong \r\nulong \r\nstring \r\nchar \r\nbool \r\nvar");
        }
    }
}
