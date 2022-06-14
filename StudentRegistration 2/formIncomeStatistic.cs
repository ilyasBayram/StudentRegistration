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

namespace StudentRegistration_2
{
    public partial class formIncomeStatistic : Form
    {
        public formIncomeStatistic()
        {
            InitializeComponent();
        }

        mySqlConnection connection = new mySqlConnection();

        private void formIncomeStatistic_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select sum(paidamount) from tblbank", connection.connection());
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                lblMoney.Text = read[0].ToString() + " TL";
            }

            connection.connection().Close();

            SqlCommand command2 = new SqlCommand("Select distinct (paidmounth) from tblbank", connection.connection());
            SqlDataReader read2 = command2.ExecuteReader();
            while (read2.Read())
            {
                cmBoxChoosenMounth.Items.Add(read2[0].ToString());
            }
            connection.connection().Close();

        }

        private void cmBoxChoosenMounth_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select sum(paidamount) from tblbank where paidmounth=@p1", connection.connection());
            command.Parameters.AddWithValue("@p1", cmBoxChoosenMounth.Text);
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                lblMoneyChoosenMounth.Text = read[0].ToString();
            }
            connection.connection().Close();

        }
    }
}
