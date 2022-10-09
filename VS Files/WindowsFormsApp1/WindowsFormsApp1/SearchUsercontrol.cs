using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApp1
{
    public partial class SearchUsercontrol : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-HHFFIIR;Initial Catalog = DBMS_LAB FINAL; Integrated Security = True");
        public SearchUsercontrol()
        {
            InitializeComponent();
            
        }
        public void Dis_Data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Recovered_Patient.MR_no as PATIENT_NUMBER, Register_Patient_Details.P_First_Name as PATIENT NAME, Register_Patient_Details.P_Last_Name as LAST_NAME, Register_Patient_Details.P_Father_Name as FATHER_NAME, Register_Patient_Details.P_City as CITY, Register_Patient_Details.P_Blood_Group as BLOOD_GROUP, Recovered_Patient.D_Name as DOCTOR, Recovered_Patient.Date_Of_Adm as ADMISSION_DATE, Recovered_Patient.Date_Of_Dis as DISCHARGE_DATE, Recovered_Patient.Willing_For_Plasma_Donation as PLASMA_WILLING from Recovered_Patient inner join Register_Patient_Details on Register_Patient_Details.MR_no = Recovered_Patient.MR_no where MR.no = '" + textBox1.Text + "' "; 
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Dis_Data();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dis_Data();
        }
        public void Dis_Data1()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Recovered_Patient.MR_no as PATIENT_NUMBER, Register_Patient_Details.P_First_Name as PATIENT NAME, Register_Patient_Details.P_Last_Name as LAST_NAME, Register_Patient_Details.P_Father_Name as FATHER_NAME, Register_Patient_Details.P_City as CITY, Register_Patient_Details.P_Blood_Group as BLOOD_GROUP, Recovered_Patient.D_Name as DOCTOR, Recovered_Patient.Date_Of_Adm as ADMISSION_DATE, Recovered_Patient.Date_Of_Dis as DISCHARGE_DATE, Recovered_Patient.Willing_For_Plasma_Donation as PLASMA_WILLING from Recovered_Patient inner join Register_Patient_Details on Register_Patient_Details.MR_no = Recovered_Patient.MR_no where Willing_For_Plasma_Donation = '1';";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Dis_Data1();
        }
    }
}
