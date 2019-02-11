using System;
using System.Collections.Generic;
using System.Data.OleDb;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Database
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            
            InitializeComponent();

            
            string strConn = @"Database.accdb";
            cn = new OleDbConnection(strConn);
            //cn.ConnectionString = strConn;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string query = "select* from Assets";
            //OleDbConnection cn = null;
            OleDbCommand cmd = new OleDbCommand(query, cn);
            cn.Open();
            OleDbDataReader read = cmd.ExecuteReader();
            string data = "";

            while (read.Read())
            {
                data += read[0].ToString() + "\n";

            }

        }
    }
}
