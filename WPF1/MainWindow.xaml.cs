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
using System.Data.SqlClient;


namespace WPF1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection connection = new SqlConnection("Server=DESKTOP-MA11NJC"+@"\"+ "SQLEXPRESS01;Database=db_lab04;Integrated Security=true");
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnConsulta_Click(object sender, RoutedEventArgs e)
        {
            connection.Open();
            List<Person> people = new List<Person>();
            SqlCommand command = new SqlCommand("USP_GETPeople", connection);

            command.CommandType = CommandType.StoredProcedure;

            SqlParameter sqlParameter1 = new SqlParameter();
            sqlParameter1.SqlDbType = SqlDbType.VarChar;
            sqlParameter1.Size = 50;
            sqlParameter1.Value = "";
            sqlParameter1.ParameterName = "@LastName";

            SqlParameter sqlParameter2 = new SqlParameter();
            sqlParameter2.SqlDbType = SqlDbType.VarChar;
            sqlParameter2.Size = 50;
            sqlParameter2.Value = "";
            sqlParameter2.ParameterName = "@FistName";

            command.Parameters.Add(sqlParameter1);
            command.Parameters.Add(sqlParameter2);

            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                people.Add(new Person { 
                    PersonId = (int)dataReader["PersonId"],
                    LastName = (string)dataReader["LastName"],
                    FirstName = (string)dataReader["FirstName"],
                    HireDate = dataReader["HireDate"].ToString(),
                    EnrollmentDate = dataReader["HireDate"].ToString(),
                });
            }
            connection.Close();
            dgvPeople.ItemsSource = people;
        }
    }
}
