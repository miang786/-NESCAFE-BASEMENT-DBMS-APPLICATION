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
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-HHFFIIR;Initial Catalog = DBMS_LAB FINAL; Integrated Security = True");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            plasmaDonarUsercontrol1.Hide();
            searchUsercontrol1.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void searchUsercontrol1_Load(object sender, EventArgs e)
        {
            searchUsercontrol1.Show();
            searchUsercontrol1.BringToFront();
        }

        private void plasmaDonarUsercontrol1_Load(object sender, EventArgs e)
        {
            plasmaDonarUsercontrol1.Show();
            plasmaDonarUsercontrol1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            searchUsercontrol1.Show();
            searchUsercontrol1.BringToFront();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            plasmaDonarUsercontrol1.Show();
            plasmaDonarUsercontrol1.BringToFront();
        }
    }
}
