using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using NicoleBCharades.Models;

namespace NicoleBCharades.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<NicoleBCharades.Models.Player> Player { get; set; }
        public DbSet<NicoleBCharades.Models.Game> Game { get; set; }
        public DbSet<NicoleBCharades.Models.Card> Card { get; set; }
    }
}
