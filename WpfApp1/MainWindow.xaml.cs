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
using WpfApp1.Database;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly CarContext _context;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string brand = ForBrand.Text;
                string model = ForModel.Text;
                int doorCount = int.Parse(ForDoors.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid input. Please enter valid values.");
            }
        }
        public void Clear()
        {
            ForBrand.Text =
                ForDoors.Text =
                ForModel.Text = string.Empty;
        }
    }
}