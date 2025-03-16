using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OnlineMedicalAppointmentSystem.Domain.Models;

namespace OnlineMedicalAppointmentSystem.Infrastructure.Data
{
    public class AppDbContext:DbContext
    {
        public DbSet<Patient> Patients {get; set;}
        public DbSet<Doctor> Doctors {get; set;}
        public DbSet<Appointment> Appointments {get; set;}
        public DbSet<Schedule> Schedules {get; set;}
        public DbSet<Payment> Payments {get; set;}

        public AppDbContext(DbContextOptions<AppDbContext> options):base(options){}
    }
}