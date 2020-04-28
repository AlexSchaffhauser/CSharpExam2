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

namespace Exam2
{
    /// <summary>
    /// Interaction logic for Tabs.xaml
    /// </summary>
    public partial class Tabs : Window
    {
        public Tabs()
        {
            InitializeComponent();
        }

        private void checkTab_Checked(object sender, RoutedEventArgs e)
        {
            if (checkTab.IsChecked.Value)
            {
                tab2.Visibility = Visibility.Visible;
            }
            else 
            {
                tab2.Visibility = Visibility.Collapsed;
            }
        }
    }
}
