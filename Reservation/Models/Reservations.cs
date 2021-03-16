using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reservation.Models
{
    public class Reservations
    {

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; }
        public string Cause { get; set; }

        public Student student { get; set; }
        public TypeReservation TypeReservation { get; set; }

    }
}
