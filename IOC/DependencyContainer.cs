using CleanArch.Application.Services;
using CleanArch.Application.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using CleanArch.Domain.Interfaces;
using CleanArch.Infra.Data.Repository;
using AngularCore.YP.InvoicingApp.Application.Interfaces;
using AngularCore.YP.InvoicingApp.Application.Services;
using AngularCore.YP.InvoicingApp.Domain.Interfaces;
using AngularCore.YP.InvoicingApp.Infra.Data.Repository;

namespace CleanArch.Infra.IOC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Application Layer
            services.AddScoped<ICourseService, CourseService>();
            services.AddScoped<ICustomerService, CustomerService>();
            //Data Layer
            services.AddScoped<ICourseRepository, CourseRepository>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
        }

    }
}
