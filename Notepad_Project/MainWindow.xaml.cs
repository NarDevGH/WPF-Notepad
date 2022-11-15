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
using Notepad_Project.controls;
namespace Notepad_Project
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


        public void Window_Btn_Clicked(object sender, RoutedEventArgs e) 
        {
            File_Options file_Options = new File_Options();
            AddChild((UserControl)file_Options);
            file_Options.PointFromScreen(new Point(0,0));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
