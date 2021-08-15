using CarRentalApp.Server.Data;
using CarRentalApp.Server.IRepository;
using CarRentalApp.Shared.Domain;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalApp.Server.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private IGenericRepository<Make> _makes;
        private IGenericRepository<Model> _models;
        private IGenericRepository<Vehicle> _vehicles;
        private IGenericRepository<Booking> _bookings;
        private IGenericRepository<Customer> _custtomers;
        private IGenericRepository<Color> _colors;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }
        public IGenericRepository<Make> Makes => _makes ??= new GenericRepository<Make>(_context);
        public IGenericRepository<Model> Models => _models ??= new GenericRepository<Model>(_context);
        public IGenericRepository<Vehicle> Vehicles => _vehicles ??= new GenericRepository<Vehicle>(_context);
        public IGenericRepository<Booking> Bookings => _bookings ??= new GenericRepository<Booking>(_context);
        public IGenericRepository<Customer> Customers => _custtomers ??= new GenericRepository<Customer>(_context);
        public IGenericRepository<Color> Colors => _colors ??= new GenericRepository<Color>(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task SaveChangesAsync(HttpContext httpContext)
        {

            var user = httpContext.User.Identity.Name;

            var entries = _context.ChangeTracker.Entries()
                .Where(f => f.State == Microsoft.EntityFrameworkCore.EntityState.Modified
                || f.State == Microsoft.EntityFrameworkCore.EntityState.Added);
            foreach (var entry in entries)
            {
                ((BaseDomainModel)entry.Entity).DateUpdated = DateTime.Now;
                ((BaseDomainModel)entry.Entity).UpdatedBy = user;

                if (entry.State == Microsoft.EntityFrameworkCore.EntityState.Added)
                {
                    ((BaseDomainModel)entry.Entity).DateCreated = DateTime.Now;
                    ((BaseDomainModel)entry.Entity).UpdatedBy = user;
                }
            }
            await _context.SaveChangesAsync();
        }
    }
}
