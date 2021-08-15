using CarRentalApp.Shared.Domain;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalApp.Server.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        Task SaveChangesAsync(HttpContext httpContext);
        IGenericRepository<Make> Makes { get; }
        IGenericRepository<Model> Models { get;  }
        IGenericRepository<Vehicle> Vehicles { get;  }
        IGenericRepository<Color> Colors { get; }
        IGenericRepository<Customer> Customers { get; }
        IGenericRepository<Booking> Bookings { get; }
    }
}
