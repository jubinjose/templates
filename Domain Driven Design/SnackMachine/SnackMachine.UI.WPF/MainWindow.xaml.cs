using System.Windows;
using FactoryNameSpace = SnackMachine.Logic.NHIbernate;

namespace SnackMachine.UI.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new SnackMachineViewModel(FactoryNameSpace.SnackMachineFactory.LoadSnackMachine());
        }


    }
}
