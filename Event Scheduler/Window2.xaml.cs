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
    /// Interaction logic for Window2.xaml
    /// </summary>
    /// 
    public partial class Window2 : Window
    { // creates a list of deleted items in the delete window
        public List<int> delete = new List<int>();
        public Window2()
        { InitializeComponent();

            // grabs count from mainwindow and length grabs length of the list
            int n,length;
            n = ((MainWindow)Application.Current.MainWindow).count;
            length = ((MainWindow)Application.Current.MainWindow).Eventarray.Count;

            // makes sure the length is the same amoint as the count
            while (n != length)
            {
                n--;
            }
            // Adds  The total amount of Events to the listbox to preapare to be deleted or not
            for (int i = 0; i < n; i++)
            { 
                    Listbox1.Items.Add(((MainWindow)Application.Current.MainWindow).Eventarray[i]);    
            }
            // this will make sure the old Deleted Events from delete list, wont get deleted again
            delete.Clear();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        { // this is the delete button

            //checks to make sure the clicker has selected something from the Listbox1
            if (Listbox1.SelectedIndex == -1)
            {
                MessageBox.Show("You must select an Event ");
            } 
            // this will actual delete th event add to the list that has been deleted
            else if ((MessageBox.Show("Are you sure ", "This will delete your the entire event", MessageBoxButton.YesNo) == MessageBoxResult.Yes && Listbox1.SelectedIndex > -1))
             {
                delete.Add(Listbox1.SelectedIndex);
                Listbox1.Items.RemoveAt(Listbox1.SelectedIndex);
             }
        
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {// this button will manual close window2
            this.Close();
        }
    }
}
