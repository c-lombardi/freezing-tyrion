using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyrion.Models
{
    public abstract class DatabaseSet : DbContext, IDisposable
    {
        public DatabaseSet() : base() { }
        public DatabaseSet(string connectionString) : base(connectionString) { }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<AudioFile> AudioFiles { get; set; }

        void IDisposable.Dispose()
        {
            base.Dispose();
        }
    }
}
