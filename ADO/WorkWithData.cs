using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace ADO
{
    /// <summary>
    /// Работа с базами данных
    /// </summary>
    public class WorkWithData
    {
        #region Поля
        /// <summary>
        /// Подключение к SQL
        /// </summary>
        public SqlConnection sqlConnection { get; set; }
        /// <summary>
        /// Строка подключения к Acess
        /// </summary>
        //static string accessConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Programming\DzSkillbox\ADO\ADO\Data\MSAccessLocalDB.accdb;Persist Security Info=True";
        #endregion

        public WorkWithData()
        {
            SqlConnectionStringBuilder sqlCon = new SqlConnectionStringBuilder()
            {
                DataSource = @"(localdb)\MSSQLLocalDB",
                InitialCatalog = @"MSSQLLocalDemo",
                IntegratedSecurity = true,
                UserID = "sa",
                Password = "123",
                Pooling = false
            };
            sqlConnection = new SqlConnection(sqlCon.ConnectionString);
        }

        public void SqlConnectionStateChanger()
        {
            if (sqlConnection.State == ConnectionState.Closed)
                sqlConnection.Open();
            else
                sqlConnection.Close();
        }
    }
}
