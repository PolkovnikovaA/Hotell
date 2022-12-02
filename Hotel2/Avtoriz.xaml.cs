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

namespace Hotel2
{
    /// <summary>
    /// Логика взаимодействия для Avtoriz.xaml
    /// </summary>
    public partial class Avtoriz : Page
    {
        public Avtoriz()
        {
            InitializeComponent();
        }

        List<Hotel2.Registr> users = new List<Hotel2.Registr>();
        private void btn_AvtorizHome(object sender, RoutedEventArgs e)
        {
            string login_vx = TextBoxLogin.Text;
            string password_vx = PasswordBox.Password;
            int count = Entities.GetContext().Registr.Count();
            users = Entities.GetContext().Registr.ToList();

            for (int i = 0; i < count; i++)
            {
                if (users[i].Login == login_vx)
                {
                    if (users[i].Password == password_vx)
                    {
                        NavigationService.Navigate(new Uri("/Home.xaml", UriKind.Relative));    //Переход на страницу Home (Button)
                    }
                    else
                    {
                        MessageBox.Show("Неверный пароль");
                    }
                }
            }

            //if (login_vx != "") // проверяем введён ли логин     
            //{
            //    if (password_vx != "") // проверяем введён ли пароль         
            //    {             // ищем в базе данных пользователя с такими данными         
            //        DataTable dt_user = Select("SELECT * FROM Reg WHERE Login = '" + TextBoxLog.Text + "' AND Password = '" + TextBoxpass.Password + "'");
            //        if (dt_user.Rows.Count > 0) // если такая запись существует       
            //        {
            //            MainWindow mainWindow = new MainWindow();
            //            mainWindow.Show();
            //            Close();
            //        }
            //        else MessageBox.Show("Пользователя не найден"); // выводим ошибку  
            //    }
            //    else MessageBox.Show("Введите пароль"); // выводим ошибку    
            //}
            //else MessageBox.Show("Введите логин"); // выводим ошибку 

            
        }

        private void btn_AvtorizRegistr(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Registr.xaml", UriKind.Relative));
        }
    }
}
