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
using System.Xml.Linq;

namespace Pract9
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
        Salary salary;

        private void Отчистить_Click(object sender, RoutedEventArgs e)
        {
            inputEmployeeName.Clear();
            inputGender.Clear();
            inputPost.Clear();
            inputWages.Clear();
            inputWorkExperience.Clear();
        }

        private void О_Программе_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Заполнить таблицу со списком сотрудников на 7 человек с полями: " +
                "ФИО, пол, должность, стаж работы, оклад. " +
                "Вывести результат на экран. Вывести средний оклад.");
        }

        private void Выход_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Найти_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int sum = 0;
                for(int i = 0; i <= dataGrid.Items.Count; i++)
                {
                    sum += salary.Wages;
                }
                double averageSalary = sum / dataGrid.Items.Count;
                string res = $"Средний оклад сотрудников: "+averageSalary;
                result.Text = res;               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Добавить_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string employeeName=inputEmployeeName.Text;
                string gender=inputGender.Text;
                string post=inputPost.Text;
                int workExperience=Convert.ToInt32(inputWorkExperience.Text);
                int wages=Convert.ToInt32(inputWages.Text);           
                salary=new Salary(employeeName, gender, post, workExperience ,wages);
                dataGrid.Items.Add(salary);
                Отчистить_Click(salary, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
