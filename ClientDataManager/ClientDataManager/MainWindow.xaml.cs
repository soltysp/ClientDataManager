using System;
using System.Collections.Generic;
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
using System.Data;
using System.Data.OleDb;

namespace ClientDataManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        OleDbConnection connection;
        DataTable dt;

        /// <summary>
        /// Default Constructor where Access DataBase Connection is initialized
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();

            // Access Database connection
            connection = new OleDbConnection();
            connection.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source= ../../db/ClientDataBase1.mdb";
            ShowGrid();
        }

        /// <summary>
        /// MEthod that shows data from Access DataBase inside DataGrid
        /// </summary>
        private void ShowGrid()
        {
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "select * from ClientDB";

            OleDbDataAdapter da = new OleDbDataAdapter(command);
            dt = new DataTable();
            da.Fill(dt);

            // Set DataGrid Visibility
            clData.ItemsSource = dt.AsDataView();
            clData.Visibility = Visibility.Visible;

        }

        /// <summary>
        /// Method that clears all fields and prepare it to new data entry
        /// </summary>
        private void ClearAll()
        {
            textBoxID.Text = "";
            textBoxNm.Text = "";
            textBoxSm.Text = "";
            textBoxPn.Text = "";
            textBoxAd.Text = "";
            btnAdd.Content = "Add New";
            textBoxID.IsEnabled = true;
        }

        /// <summary>
        /// Method that allows data to be updated after clicking "Edit" Button
        /// </summary>
        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            if (clData.SelectedItems.Count > 0)
            {
                DataRowView row = (DataRowView)clData.SelectedItems[0];
                textBoxID.Text = row["ID"].ToString();
                textBoxNm.Text = row["Name"].ToString();
                textBoxSm.Text = row["Surname"].ToString();
                textBoxPn.Text = row["TelNumb"].ToString();
                textBoxAd.Text = row["Address"].ToString();
                textBoxID.IsEnabled = false;
                btnAdd.Content = "Update Data";
            }
            else
            {
                MessageBox.Show("Please Select Client To Edit Then Click The Button ");
            }
        }

        /// <summary>
        /// Method that allows entering data after clicking "Add New" Button
        /// </summary>
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            OleDbCommand command = new OleDbCommand();
            if (connection.State != ConnectionState.Open)
                connection.Open();
            command.Connection = connection;

            if(textBoxID.Text != "")
            {
                if(textBoxID.IsEnabled == true)
                {
                    if (textBoxNm.Text != "" && textBoxSm.Text != "" && textBoxPn.Text != "" && textBoxAd.Text != "")
                    {
                        command.CommandText = "insert into ClientDB(ID,Name,Surname,TelNumb,Address) Values(" + textBoxID.Text + ",'" + textBoxNm.Text + "','" + textBoxSm.Text + "'," + textBoxPn.Text + ",'" + textBoxAd.Text + "')";
                        command.ExecuteNonQuery();
                        ShowGrid();
                        MessageBox.Show("Your New Client Added Succesfully!");
                        ClearAll();
                    }
                    else
                    {
                        MessageBox.Show("Please Fill All Blank Spaces!");
                    }
                }
                else
                {
                    command.CommandText = "update ClientDB set Name='" + textBoxNm.Text + "',Surname='" + textBoxSm.Text + "',TelNumb=" + textBoxPn.Text + ",Address='" + textBoxAd.Text + "' where ID=" + textBoxID.Text;
                    command.ExecuteNonQuery();
                    ShowGrid();

                    MessageBox.Show("Client Data Updated Succesffully!");
                    ClearAll();
                }

            }
            else
            {
                MessageBox.Show("Please Add Customer Id ");
            }
        }

        /// <summary>
        /// Method that allows to remove data after clicking on "Delete" button
        /// </summary>
        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (clData.SelectedItems.Count > 0)
            {
                DataRowView row = (DataRowView)clData.SelectedItems[0];

                OleDbCommand command = new OleDbCommand();
                if (connection.State != ConnectionState.Open)
                    connection.Open();

                command.Connection = connection;
                command.CommandText = "delete from ClientDB where ID=" + row["ID"].ToString();
                command.ExecuteNonQuery();
                ShowGrid();

                MessageBox.Show("Client Removed Succesfully ");
                ClearAll();
            }
            else
            {
                MessageBox.Show("Select Any Client To Delete ");
            }

        }
    }
}
