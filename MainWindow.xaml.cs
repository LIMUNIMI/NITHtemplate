using NITHtemplate.Setups;
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

namespace NITHtemplate
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly DefaultSetup _defaultSetup;

        public MainWindow()
        {
            InitializeComponent();

            // Launch Setup
            _defaultSetup = new DefaultSetup(this);
            _defaultSetup.Setup();
        }
    }
}