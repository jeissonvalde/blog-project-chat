using System.Data.SqlClient;

// namespace technical_assistant.Datos
namespace technical_assistant.Data
{
    public class Connection
    {
        private string sql_conn_data = string.Empty;
        public Connection() {

            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();

            sql_conn_data = builder.GetSection("ConnectionStrings:Sql_conn_data").Value;
        }

        public string getSQLConnectionData() {
            return sql_conn_data;
        }
    }
}
