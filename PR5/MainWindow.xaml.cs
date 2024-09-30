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

namespace PR5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string[] AArray = new string[50]; //{ "Petr" , "Nikitos" , "Andruha" , "Oleg"};
         
        public MainWindow()
        {
            InitializeComponent();
            ListBoxString.Items.Clear();
            foreach (string Texta in AArray)
            {
                ListBoxString.Items.Add(Texta);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox != null)
            {

                for (int runs = 0; runs < 50; runs++)
                {
                    if (AArray[runs] == null )
                    {
                        AArray[runs] = TextBox.Text;
                        break;
                    }
                    
                }

                ListBoxString.Items.Clear();

                foreach (string Texta in AArray)
                {
                    ListBoxString.Items.Add(Texta);
                }

            }
            TextBox.Clear();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (TextBox != null)
            {

                for (int runs = 0; runs < 50; runs++)
                {
                    
                    
                    if (AArray[runs] == TextBox.Text);
                    {
                        AArray = null;
                        break;
                    }
                        
                    

                }

                ListBoxString.Items.Clear();

                foreach (string Texta in AArray)
                {
                    ListBoxString.Items.Add(Texta);
                }

            }
            TextBox.Clear();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (ListBoxString.SelectedItem != null && TextBox.Text != null)
            {
                int i = ListBoxString.Items.IndexOf(ListBoxString.SelectedItem);
                ListBoxString.Items[i] = TextBox.Text;
            }
        }
        
    }
}
