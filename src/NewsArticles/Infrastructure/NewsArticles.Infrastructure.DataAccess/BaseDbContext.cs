using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsArticles.Infrastructure.DataAccess
{
    /// <summary>
    /// Контекст для работы с базой данных
    /// </summary>
    public class BaseDbContext : DbContext
    {
        public BaseDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new )

            base.OnModelCreating(modelBuilder);
        }
    }
}
