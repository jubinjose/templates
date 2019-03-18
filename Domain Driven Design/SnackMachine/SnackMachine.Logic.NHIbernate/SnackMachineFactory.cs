using NHibernate;

namespace SnackMachine.Logic.NHIbernate
{
    public static class SnackMachineFactory
    {
        public static Model.SnackMachine LoadSnackMachine()
        {
            using (ISession session = SessionFactory.OpenSession())
            {
                var snackMMachine = session.Get<Model.SnackMachine>(1L);
                return snackMMachine;
            }
        }

        public static void SaveSnackMachine(Model.SnackMachine machine)
        {
            using (ISession session = SessionFactory.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.SaveOrUpdate(machine);
                    transaction.Commit();
                }
            }
        }

        public static void Init(string connectionString)
        {
            SessionFactory.Init(connectionString);
        }
    }
}
