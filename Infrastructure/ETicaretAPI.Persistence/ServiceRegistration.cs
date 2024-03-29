﻿using Microsoft.EntityFrameworkCore;
using ETicaretAPI.Persistence.Contexts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Persistence.Repositories;

namespace ETicaretAPI.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<ETicaretAPIDbContext>(options => options.UseNpgsql(Configuration.ConnectionString));
            services.AddScoped<ICustomerReadRepository, CustomerReadRepository>();
            services.AddScoped<ICustomerWriteRepository, CustomerWriteRepository>();
            services.AddScoped<IOrderReadRepository, OrderReadRepository>();
            services.AddScoped<IOrderWriteRepository, OrderWriteRepository>();
            services.AddScoped<IProductReadRepository, ProductReadRepository>();
            services.AddScoped<IProductWriteRepository, ProductWriteRepository>();
            services.AddScoped<IExerciseReadRepository, ExerciseReadRepository>();
            services.AddScoped<IExerciseWriteRepository, ExerciseWriteRepository>();
            services.AddScoped<ICategoryReadRepository, CategoryReadRepository>();
            services.AddScoped<ICategoryWriteRepository, CategoryWriteRepository>();
            services.AddScoped<ICategoryImageWriteRepository, CategoryImageWriteRepository>();
            services.AddScoped<ICategoryImageReadRepository, CategoryImageReadRepository>();
            services.AddScoped<IExerciseImageReadRepository, ExerciseImageReadRepository>();
            services.AddScoped<IExerciseImageWriteRepository, ExerciseImageWriteRepository>();
            services.AddScoped<IExerciseVideoReadRepository, ExerciseVideoReadRepository>();
            services.AddScoped<IExerciseVideoWriteRepository, ExerciseVideoWriteRepository>();
        }
    }
}
