using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Statanly.Web.Infrastructure.IRepositories;

namespace Statanly.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext, IUnitOfWork
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
             : base(options)
        {
            if (!_migrated[0])
                lock (_migrated)
                    if (!_migrated[0])
                    {
                        Database.Migrate(); // apply all migrations
                        _migrated[0] = true;
                    }
            Database.EnsureCreated();
        }
        private static readonly bool[] _migrated = { false };
        //public ApplicationDbContext(
        //    DbContextOptions options,
        //    IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        //{
        //    if (!_migrated[0])
        //        lock (_migrated)
        //            if (!_migrated[0])
        //            {
        //                Database.Migrate(); // apply all migrations
        //                _migrated[0] = true;
        //            }
        //    Database.EnsureCreated();
        //}
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
            builder.Entity<Click>().Property(b => b.Id).ValueGeneratedOnAdd();
        }

        public DbSet<Click> Clicks { get; set; }

        public bool Save()
        {
            var error = "";
            try
            {
                this.SaveChanges();
            }
            catch (Exception ex)
            {
                error = ex.Message;
                this.Dispose();
                return error == "";
            }
            return true;
        }
        public async Task<bool> SaveAsync()
        {
            try
            {
                await this.SaveChangesAsync();
            }
            catch
            {
                this.Dispose();
                return false;
            }
            return true;
        }
    }
}
