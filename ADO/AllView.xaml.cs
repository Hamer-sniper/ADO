using ADO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Microsoft.Data.SqlClient;
using System.Data.OleDb;

namespace ADO
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class AllView : Window
    {
        WorkWithData workWithData = new WorkWithData();

        public AllView()
        {
            InitializeComponent();

            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter();

            SqlConnection con = workWithData.sqlConnection;

            var sql = @"SELECT * FROM SQL_Table";

            /*var sql = @"SELECT 
Workers.id as 'ID',
Workers.workerName as 'Имя сотрудника',
Bosses.workerName  as 'Имя начальника',
Bosses.departmentName  as 'Имя отдела',
[Description].[value] as 'Замечание'
FROM  Workers, Bosses, [Description]
WHERE Workers.idBoss = Bosses.id and Workers.idDescription = [Description].id
Order By Workers.Id";*/

            da.SelectCommand = new SqlCommand(sql, con);
            da.Fill(dt);

            gridAllView.DataContext = dt.DefaultView;
        }

        public AllView(DataRowView row)
        {
            InitializeComponent();

            DataTable dt = new DataTable();

            OleDbDataAdapter da = new OleDbDataAdapter();

            OleDbConnection oleDbCon = workWithData.oleDbConnection;

            var ole = @"SELECT * FROM Access_Table";

            da.SelectCommand = new OleDbCommand(ole, oleDbCon);
            
            da.Fill(dt);

            gridAllView.DataContext = dt.DefaultView;
        }
    }
}
