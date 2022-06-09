using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace StudentRegistration_2
{
    public class mySqlConnection
    {
        public SqlConnection connection()
        {
            SqlConnection connect = new SqlConnection(@"Data Source=NB3401-0011;Initial Catalog=DbDormitoryRegistration;Integrated Security=True");
            connect.Open();
            return connect;
        }

    }
}
