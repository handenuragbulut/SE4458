using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;


namespace HandenurAgbulutMidterm.Models
{
    public class se4458DbContext: DbContext
    {

        public se4458DbContext(DbContextOptions<se4458DbContext> options) : base(options) { }

        public DbSet<Subscriber> Subscribers { get; set; }
        public DbSet<Bill> Bills { get; set; }
    }
}
