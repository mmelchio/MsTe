using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoReservation.Dal
{
    public abstract partial class Auto
    {
        public Auto()
        {
            this.Reservations = new HashSet<Reservation>();
        }

        public int Id { get; set; }
        public string Marke { get; set; }
        public int Tagestarif { get; set; }

        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
