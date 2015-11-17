using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoReservation.Dal
{
    public partial class Reservation
    {
        public int ReservationNr { get; set; }
        public int AutoId { get; set; }
        public int KundeId { get; set; }
        public System.DateTime Von { get; set; }
        public System.DateTime Bis { get; set; }

        public virtual Auto Auto { get; set; }
        public virtual Kunde Kunde { get; set; }
    }
}
