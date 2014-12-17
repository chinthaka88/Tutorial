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
using System.Configuration;


namespace ClassLibrary1_ADO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //string connString = DataLayer.DB.ConnectionString;
            DB.ApplicationName = "WinDemo Application";
            DB.ConnectionTimeout = 30;
            SqlConnection conn = DB.GetSqlConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Employees es = new Employees();
                Employee employee = es.GetEmployee(int.Parse(textBoxEID.Text));

                textBoxFName.Text = employee.FirstName;
                textBoxLName.Text = employee.LastName;
                textBoxDName.Text = employee.DepartmentName;

            }
            catch { }
        }
    }
}
