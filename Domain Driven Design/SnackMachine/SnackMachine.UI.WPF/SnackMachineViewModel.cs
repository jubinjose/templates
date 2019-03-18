using Model = SnackMachine.Logic.NHIbernate.Model;
using System;
using System.ComponentModel;
using FactoryNameSpace = SnackMachine.Logic.NHIbernate;

namespace SnackMachine.UI.WPF
{
    public class SnackMachineViewModel : INotifyPropertyChanged
    {
        private readonly Model.SnackMachine _snackMachine;

        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }

        public Command InsertFiveCentCommand { get; }
        public Command InsertTenCentCommand { get; }
        public Command InsertDollarCommand { get; }
        public Command InsertFiveDollarCommand { get; }
        public Command BuySnackCommand { get; }
        public Command ReturnMoneyCommand { get; }


        public SnackMachineViewModel(Model.SnackMachine snackMachine)
        {
            _snackMachine = snackMachine;

            InsertFiveCentCommand = new Command(() => InsertMoney(Model.Money.FiveCent));
            InsertTenCentCommand = new Command(() => InsertMoney(Model.Money.TenCent));
            InsertDollarCommand = new Command(() => InsertMoney(Model.Money.Dollar));
            InsertFiveDollarCommand = new Command(() => InsertMoney(Model.Money.FiveDollar));
            BuySnackCommand = new Command(()=> BuySnack());
            ReturnMoneyCommand = new Command(() => ReturnMoney());
        }

        public String MoneyInTransaction
        {
            get
            {
                return _snackMachine.MoneyInTransaction.ToString();
            }
        }

        public string MachineName
        {
            get
            {
                return _snackMachine.Name;
            }
            set
            {
                _snackMachine.Name = value;
                NotifyPropertyChanged(nameof(MachineName));
            }
        }

        public String MoneyInside
        {
            get
            {
                return _snackMachine.MoneyInside.ToString();
            }
        }

        protected  void InsertMoney(Model.Money coinOrNote)
        {
            _snackMachine.InsertMoney(coinOrNote);
            NotifyPropertyChanged(nameof(MoneyInTransaction));
        }

        private void BuySnack()
        {
            //Release a snack(assume), Take all Money in transaction inside and save to Database
            _snackMachine.BuySnack();
            NotifyPropertyChanged(nameof(MoneyInTransaction));
            NotifyPropertyChanged(nameof(MoneyInside));

            FactoryNameSpace.SnackMachineFactory.SaveSnackMachine(_snackMachine);
        }

        private void ReturnMoney()
        {
            //Return money inside w/o buying a snack (i.e. cancel the transaction)
            _snackMachine.ReturnMoney();
            NotifyPropertyChanged(nameof(MoneyInTransaction));
        }
    }
}
