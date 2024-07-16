using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latih13_MdiFormLanjutan
{
    public class ConnDbContext : DbContext
    {
        public DbSet<PegawaiModel> TB_Employee { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=localhost; Database=Db_KerjaPraktek; Trusted_Connection = True ;TrustServerCertificate=True");
        }
    }
}
