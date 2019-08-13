using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace pjConexion02
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection("Data Source=LAB402-20\\SQLEXPRESS;Initial Catalog=neptuno;Integrated Security=True");


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListaClientes();
        }

        public void ListaClientes()
        {
            using (SqlDataAdapter Df = new SqlDataAdapter("Select * from clientes", cn))
            {
                using (DataSet Da = new DataSet())
                {
                    Df.Fill(Da, "Clientes");
                    DgClientes.DataSource = Da.Tables["Clientes"];
                    lblTotal.Text = Da.Tables["Clientes"].Rows.Count.ToString();

                }

            }
        }
    }
}
