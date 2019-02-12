/*
 * Author: Hunter Haislip
 * Date: 2/12/18
 * File: MainWindow.xaml.cs
 * Description: The main C# file
 */

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
    public partial class MainWindow : Window
    {
        OleDbConnection cn;
        public MainWindow()
        {
            InitializeComponent();
            cn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|Database.accdb");

            //OleDbConnection cn; 
            string strConn = "Database.accdb";
            cn = new OleDbConnection(strConn);
            //cn.ConnectionString = strConn;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string query = "select* from Assets";
            OleDbCommand cmd = new OleDbCommand(query, cn);
            cn.Open();
            OleDbDataReader read = cmd.ExecuteReader();
            string data = "";

            while (read.Read())
            {
                data += "EmployeeID: " + read[0] + "     "
                     + "AssestID: " + read[1] + "     "
                     + "Description: " + read[2] + "\n";
            }

            TextBox1.Text = data;
            cn.Close();
        }

        private void Employees1_Click(object sender, RoutedEventArgs e)
        {
            string query = "select* from Employees";
            OleDbCommand cmd = new OleDbCommand(query, cn);
            cn.Open();
            OleDbDataReader read = cmd.ExecuteReader();
            string data = "";

            while (read.Read())
            {
                data += "EmployeeID: " + read[0] + "     "
                     + "FirstName: " + read[1] + "     "
                     + "LastName: " + read[2] + "\n";
            }

            TextBox1.Text = data;
            cn.Close();
        }
    }
}
