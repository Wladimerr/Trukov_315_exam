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
using Trukov_315_exam.Model;

namespace Trukov_315_exam
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Worker worker;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            tbLogin.Text = "";
            passwordBox.Password = "";
            worker = null;
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            worker = DBCon.context.Worker.Where(w => w.Login == tbLogin.Text).FirstOrDefault();
            if (worker == null)
            {
                MessageBox.Show("Пользователь с таким логином не найден!");
            }
            else 
            {
                if (worker.Password != passwordBox.Password)
                    MessageBox.Show("Пароль неверный!");
                else
                    MessageBox.Show("Вы успешно вошли!");
            }
                
        }
    }
}
