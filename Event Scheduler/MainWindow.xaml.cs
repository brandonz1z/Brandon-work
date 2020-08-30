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

namespace Event_Scheduler
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {   // The List created for each Eventt
        //count is change every time a event is created
        public int count;
        public List<string> Eventarray = new List<string>();
        public List<string> Locatearray = new List<string>();
        public List<string> Montharray = new List<string>();
        public List<string> Yeararray = new List<string>();
        public List<string> Detailsarray = new List<string>();
        //textbox entered from month and year
        public String M, Y;
        public MainWindow()
        {//grabing the text for month and year
            InitializeComponent();
       
        }

        private void Modifty_Event(object sender, RoutedEventArgs e)
        {

        }

        private void Add_event_Copy_Click(object sender, RoutedEventArgs e)
        {// opening a new window to search event and grabs month and year textbox
            if (Eventarray.Count == 0)
            {
                MessageBox.Show("There arent any events");
            }
            else
            {
                this.M = TextboxMonth.Text;
                this.Y = TextboxYear.Text;
                Window3 c = new Window3();
                c.Show();
            }
        }
       

         void B_closed(object sender, EventArgs e)
        {// grabs the events details once window 1 is closed
            Window1 b = (Window1)sender;
            this.Eventarray.Add (b.EventName);
            this.Locatearray.Add (b.Locate);
            this. Montharray.Add  (b.Months);
            this.Yeararray.Add  (b.Years);
            this.Detailsarray.Add (b.Details);
            this.count++;
            
        }

        private void Add_event_Copy1_Click(object sender, RoutedEventArgs e)
        { // opes new window to delete an event

            if (Eventarray.Count == 0)
            {
                MessageBox.Show("There arent any events");
            }
            else {
                Window2 window = new Window2();
                window.Show();
                window.Closed += Window_closed;
            }
        }

        void Window_closed(object sender, EventArgs e)
        { // this will delete Event from the list once window two is closed
            Window2 w = (Window2)sender;
            for (int i = 0; i <= w.delete.Count-1; i++)
            {   this.Eventarray.RemoveAt(w.delete[i]);
                this.Locatearray.RemoveAt(w.delete[i]);
                this.Montharray.RemoveAt(w.delete[i]);
                this.Yeararray.RemoveAt(w.delete[i]);
                this.Detailsarray.RemoveAt(w.delete[i]);
            }
        }

        // clears textbox once clicked
        private void TextboxYear_GotFocus(object sender, RoutedEventArgs e)
        {
            TextboxYear.Text = String.Empty;
        }

        private void TextboxMonth_GotFocus(object sender, RoutedEventArgs e)
        {
            TextboxMonth.Text = String.Empty;
        }

        // makes sure text is cleared when texbox is selected


        private void Add_Event_Click(object sender, RoutedEventArgs e)
        {// opens new window to add an event
           
                Window1 b = new Window1();
                b.Show();
                b.Closed += B_closed;
            
        }
    }
    
}
 