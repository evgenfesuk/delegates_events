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
using Logic;

namespace Delegates_Events_Testing
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TestClass t = new TestClass();
            /*Action<string> m = TestClass.Show;
            //t.Moving = TestClass.Show;*/
            t.Moving += T_Moving;
            t.Move(5);
        }

        private void T_Moving(string message)
        {
            MessageBox.Show(message);
        }
    }
}
