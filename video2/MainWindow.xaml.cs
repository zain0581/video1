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

namespace video2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //button.FontSize = 50;
            //button.Content = "click me";
        }

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Uri.AbsoluteUri);


        }

        // Hvad sker der hvis man cliker på Button:
        private void form1_Click(object sender, RoutedEventArgs e)
        {
            // hvis navn felt er ikke tomt så kan man kom vider 
            if (text.Text != "")
            {
                // text farve og størlse ville ændret 
                text.Foreground = Brushes.Red;
                text.FontSize = 30;
                button.Background = Brushes.Pink;

                // Besked med navn ..
                MessageBox.Show($" Hello { text.Text}");

                // Nyt window form vill åbnet..

                Window1 p = new Window1();  
                p.Show();
                this.Close();


            }
            // ellers man vil får en error message
            else
            {
              text.Background = Brushes.LightGray;
                MessageBox.Show ("Skrive noget i Navn felt");
            }

            



        }

       
    }
}
