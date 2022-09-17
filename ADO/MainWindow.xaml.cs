using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ADO
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        WorkWithData workWithData = new WorkWithData();

        public MainWindow()
        {
            InitializeComponent();

            SqlConnectionStringTextBox.Text = workWithData.sqlConnection.ConnectionString;

            workWithData.sqlConnection.StateChange += new StateChangeEventHandler(OnStateChange);
        }

        public void OnStateChange(object sender, StateChangeEventArgs args)
        {
            SqlConnectionStateTextBox.Text = args.CurrentState.ToString();
            if (args.CurrentState == System.Data.ConnectionState.Closed)
                SqlInfoShowButton.Content = "Открыть соединение с SQL";
            else
                SqlInfoShowButton.Content = "Закрыть соединение с SQL";
        }

        private void SqlInfoShowButton_Click(object sender, RoutedEventArgs e)
        {            
            workWithData.SqlConnectionStateChanger();
        }
    }
}
