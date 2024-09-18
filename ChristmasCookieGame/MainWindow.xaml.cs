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

namespace ChristmasCookieGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string message = "Hello World!";
        public string newMessage = "Merry Christmas!";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ClickMeTest_Click(object sender, RoutedEventArgs e)
        {
            PopUpWithMessage(message);
        }
        public void PopUpWithMessage(string message)
        {
            MessageBox.Show(message);
            UpdateMessage(newMessage);
        }

        public void UpdateMessage(string newMessage)
        {
            message = newMessage;
        }
    }
}