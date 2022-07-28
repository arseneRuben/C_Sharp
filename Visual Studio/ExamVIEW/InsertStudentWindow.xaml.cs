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
using System.Windows.Shapes;

namespace ExamVIEW
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class InsertStudentWindow : Window
    {
        public InsertStudentWindow()
        {
            InitializeComponent();
        }

        private void HandleCheck(object sender, RoutedEventArgs e)
        {
           
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String name = this.name.Text;
            int age = Convert.ToInt32(this.age.Text);
            DateTime birthday = Convert.ToDateTime(this.birthday.Text);
            bool international = Convert.ToBoolean(this.international.IsChecked);
            ExamBLL.StudentManager.AddStudent(name, age, birthday, international);
        }

        private void International_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
