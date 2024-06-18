using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Company
{
    internal class DataAccess
    {

        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader reader;

        public SqlDataReader Reader
        {
            get { return reader; }
        }

        public DataAccess()
        {
            connection = new SqlConnection("server=.\\SQLEXPRESS; database=CATALOGO_DB; integrated security=true");
            command = new SqlCommand();
        }

        public void SetQuery(string query)
        {
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = query;
        }

        public void ExecuteReading()
        {
            command.Connection = connection;

            try
            {
                connection.Open();
                reader = command.ExecuteReader();
            }
            catch (Exception exception)
            {

                throw exception;
            }
        }

        public void SetParameter(string name, object value) => command.Parameters.AddWithValue(name, value);

        public void ExecuteAction()
        {
            command.Connection = connection;

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public void ClosedConnection()
        {
            if (reader != null)
                reader.Close();

            connection.Close();
        }

    }
}
