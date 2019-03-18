using FactoryNameSpace = SnackMachine.Logic.NHIbernate;
using System.Windows;

namespace SnackMachine.UI.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            FactoryNameSpace.SnackMachineFactory.Init(@"Server=.\SQLEXPRESS;Database=jubindb;Trusted_Connection=true");
        }
    }
}
