﻿using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace ShortUrl.Data
{
    public class DefaultDbContext : DbContext
    {
        public DbSet<Entities.Url> Urls { get; set; }

        public DefaultDbContext(DbContextOptions<DefaultDbContext> options):base(options)
        {

        }
    }
}
