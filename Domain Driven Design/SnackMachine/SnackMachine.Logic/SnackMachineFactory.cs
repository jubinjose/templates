namespace SnackMachine.Logic
{
    public static class SnackMachineFactory
    {
        public static Model.SnackMachine LoadSnackMachine()
        {
            return new Model.SnackMachine();
        }

        public static void SaveSnackMachine(Model.SnackMachine machine)
        {
            //Do Nothing sicne this project has no ORM or Database
        }

        public static void Init(string connectionString)
        {
            //Do Nothing sicne this project has no ORM or Database
        }
    }
}
