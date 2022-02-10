﻿using Microsoft.EntityFrameworkCore;
using Uppgift_Api_.Models.Entities;

namespace Uppgift_Api_
{
    public class SqlContext : DbContext
    {
        public SqlContext()
        {

        }

        public SqlContext(DbContextOptions<SqlContext> options) : base(options)
        {
        }

        public virtual DbSet<CategoryEntity> Categories { get; set; }
        public virtual DbSet<CustomerEntity> Customers { get; set; }
        public virtual DbSet<CustomerAddressEntity> Addresses { get; set; }
        public virtual DbSet<HandlerEntity> Handlers { get; set; }
        public virtual DbSet<OrderEntity> Orders { get; set; }
        public virtual DbSet<OrderHandlerEntity> OrderHandlers { get; set; }
        public virtual DbSet<ProductEntity> Products { get; set; }

    }
}
