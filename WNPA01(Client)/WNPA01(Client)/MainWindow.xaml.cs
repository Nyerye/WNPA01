using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WNPA01_Client_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            //Clear the boxes on launch.
            SendBox.Clear();
            SendIPBox.Clear();
            SendPortBox.Clear();
        }

        /// <summary>
        /// Opens the About Window properly, unable to be resized or closed with window controls.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AboutMenuButton_Click(object sender, RoutedEventArgs e)
        {
            About aboutWindow = new About();
            aboutWindow.ShowDialog();
        }

        /// <summary>
        /// Method for handling logic when the user presses the Send button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SendBtn_Click(object sender, RoutedEventArgs e)
        {
            

        }


        /// <summary>
        /// Method to append received messages to the TransactionLog Listbox.
        /// </summary>
        /// <param name="msg"></param>
        public void AppendReceivedMessage(string msg) //To Be more used yet with the ACK
        {

            
        }

        /// <summary>
        /// Method to handle cross thread dispatching so when a client receives a response, they can display it in the TransactioLog Lisbox.
        /// </summary>
        /// <param name="str"></param>
        private void SetTextDispatch(object str)
        {
            
        }

        /// <summary>
        /// Method to handle logic when the user presses the Exit button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            
        }


        /// <summary>
        /// Method to handle logic when the window is loaded.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        /// <summary>
        /// Method to handle logic when the window is closing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Closing(object sender, CancelEventArgs e)
        {

        }
    }
}
   