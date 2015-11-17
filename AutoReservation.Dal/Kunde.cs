using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoReservation.Dal
{
    public partial class Kunde
    {
        public Kunde()
        {
            this.Reservations = new HashSet<Reservation>();
        }

        public int Id { get; set; }
        public string Nachname { get; set; }
        public string Vorname { get; set; }
        public System.DateTime Geburtsdatum { get; set; }

        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
