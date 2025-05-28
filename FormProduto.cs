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

namespace SisLanchonete
{
    public partial class FormProduto : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\ACB Fibra\\Documents\\Projetos\\SisLanchonete\\DbLanchonete.mdf\";Integrated Security=True");

        public FormProduto()
        {
            InitializeComponent();
        }
    }
}
