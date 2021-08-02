using EPP.Application.Contracts.Data;
using EPP.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EPP.Infrastructure.Data
{
    public class EppDbContext : DbContext, IEppDbContext
    {
        public EppDbContext(DbContextOptions<EppDbContext> options) : base(options)
        {

        }
        public DbSet<Exceller> Excellers { get; set; }

    }
}
