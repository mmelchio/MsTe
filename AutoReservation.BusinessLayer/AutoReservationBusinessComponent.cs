using System.Collections.Generic;

namespace AutoReservation.Dal
{
    public class AutoReservationBusinessComponent
    {

        private static void HandleDbConcurrencyException<T>(AutoReservationEntities context, T original) where T : class
        {
            var databaseValue = context.Entry(original).GetDatabaseValues();
            context.Entry(original).CurrentValues.SetValues(databaseValue);

            throw new LocalOptimisticConcurrencyException<T>(string.Format("Update {0}: Concurrency-Fehler", typeof(T).Name), original);
        }

        public void UpdateKunde(Kunde modified, Kunde original)
        {

        }

        public List<Kunde> GetKunden()
        {
            return null;
        }

        public Kunde GetKunde()
        {
            return null;
        }

        public void DeleteKunde(Kunde kunde)
        {

        }

        public void InsertKude(Kunde kunde)
        {

        }
    }
}