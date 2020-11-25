using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmKardesligi.Models
{
    public class FilmKardesligiContext : DbContext
    {
        public FilmKardesligiContext() : base("name=FilmKardesligiContext")
        {
            Database.SetInitializer(new MyInitializationStrategy());
        }

        public DbSet<Tur> Turler { get; set; }
        public DbSet<Film> Filmler { get; set; }
    }
}
