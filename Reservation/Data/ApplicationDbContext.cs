

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Reservation.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reservation.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Reservations> Reserva { get; set; }

        public DbSet<Student> Students { get; set; }
        public DbSet<TypeReservation> TypeReservation { get; set; }

    }
    
}
