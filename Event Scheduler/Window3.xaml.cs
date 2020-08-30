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
    /// Interaction logic for Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
            // created var used for upcoming assignments
            int n, length,compare1,compare2;
            String Month, Year;

            // this will bring the needed variables from the main window and also makes length the var for the length of Events
            n = ((MainWindow)Application.Current.MainWindow).count;
            length = ((MainWindow)Application.Current.MainWindow).Eventarray.Count;
            Month = ((MainWindow)Application.Current.MainWindow).M;
            Year = ((MainWindow)Application.Current.MainWindow).Y;
          
            // this will allow the length to always equals the count 
            while (n != length)
            {
                n--;
            }
            // creates a list for the upcoming objects and also clears for the a new search 
            var newEvent = new List<Events>();
            newEvent.Clear();

            {// this loop is design to create a list of the events by the date entered by the user
                for (int i = 0; i < n; i++)
                {    // this will compare the text entered by the user to see if any Events match the search criteria
                    compare1 = string.Compare(((MainWindow)Application.Current.MainWindow).Montharray[i].ToLower(), Month.ToLower());
                    compare2 = string.Compare(((MainWindow)Application.Current.MainWindow).Yeararray[i], Year);

                    //if a date entered is the same as an event this will bring it to the list
                    if (compare1 == 0 && compare2 == 0)
                    {

                        newEvent.Add(new Events { Name = "Event#" + (i + 1) });
                        newEvent[i].Eventname = ((MainWindow)Application.Current.MainWindow).Eventarray[i];
                        newEvent[i].Location = ((MainWindow)Application.Current.MainWindow).Locatearray[i];
                        newEvent[i].Month = ((MainWindow)Application.Current.MainWindow).Montharray[i];
                        newEvent[i].Year = ((MainWindow)Application.Current.MainWindow).Yeararray[i];
                        newEvent[i].EventDetail = ((MainWindow)Application.Current.MainWindow).Detailsarray[i];
                        Datagrid1.Items.Add(newEvent[i]);
                    }
                    else if (compare1 != 0 || compare2 != 0)
                    {// Allow you to to check for events after you have already checked
                        newEvent.Add(new Events { Name = "Event#" + (i + 1) });//
                    }
                }
                        
                   
                
   }
    
   }

  }

      public class Events
 { // creates the Strings for the Events object to be sent to the Datagrid
            public String Name {get; set;}
            public string Eventname { get; set; }
            public string Location { get; set; }
            public string Month { get; set; }
            public string Year{ get; set; }
            public string EventDetail { get; set; }
        }

}
