using EPP.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EPP.Application.Contracts.Data
{
    public interface IEppDbContext
    {
        public DbSet<Exceller> Excellers { get; }
    }
}
