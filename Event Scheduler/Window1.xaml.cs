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

namespace Event_Scheduler
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
   
    public partial class Window1 : Window
    {//creates Strings for textboxes in window 1
        public String EventName, Locate, Months, Years, Details;

        // clears textbox once clicked
        private void Textbox3_GotFocus(object sender, RoutedEventArgs e)
        {
            textbox3.Text = String.Empty;
        }

        private void Textbox4_GotFocus(object sender, RoutedEventArgs e)
        {
            textbox4.Text = String.Empty;
        }


        private void Textbox5_GotFocus_1(object sender, RoutedEventArgs e)
        {
            textbox5.Text = String.Empty;
        }

        private void Textbox2_GotFocus(object sender, RoutedEventArgs e)
        {
            textbox2.Text = String.Empty;
        }

        private void Textbox1_GotFocus(object sender, RoutedEventArgs e)
        {
            textbox1.Text = String.Empty;
        }

        public Window1()
        {
            InitializeComponent();
            
                }

        private void Button_Click(object sender, RoutedEventArgs e)
            {
               if(textbox1.Text.Length > 0)
            { //grabs the text from window 1 and assign them to variable
                this.EventName = textbox1.Text;
                this.Locate = textbox2.Text;
                this.Months = textbox3.Text;
                this.Years = textbox4.Text;
                this.Details = textbox5.Text;
                this.Close();
                }       
            }
    }
}
