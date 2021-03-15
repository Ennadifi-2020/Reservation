using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reservation.Models
{
    public class TypeReservation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AccessNumber { get; set; }
        public ICollection<Reservations> Reservation { get; set; }
    }
}
