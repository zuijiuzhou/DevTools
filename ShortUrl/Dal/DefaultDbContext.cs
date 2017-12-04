﻿using Microsoft.EntityFrameworkCore;
using System.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace ShortUrl.Dal
{
    public class DefaultDbContext : DbContext
    {
        public DbSet<Entities.Url> Urls { get; set; }

        public DefaultDbContext()
        {

        }

        public DefaultDbContext(DbContextOptions<DefaultDbContext> options) :base( options)
        {
            
        }
    }
}