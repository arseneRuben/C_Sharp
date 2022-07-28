using ExamBLL;
using ExamModel;
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

namespace ExamVIEW
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string name = this.name.Text;
            string password = this.password.Password;

            Admin adm = AdminManager.Login(name, password);
           
            if( adm != null)
            {
                new InsertStudentWindow();
                this.Hide();
            }else
            {
                MessageBox.Show("Erreur de login");
            }
        }
    }
}
