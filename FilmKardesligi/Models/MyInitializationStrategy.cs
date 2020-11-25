using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmKardesligi.Models
{
    public class MyInitializationStrategy : CreateDatabaseIfNotExists<FilmKardesligiContext>
    {
        protected override void Seed(FilmKardesligiContext context)
        {
            Tur tur1 = new Tur { TurAd = "Macera" };
            Tur tur2 = new Tur { TurAd = "Fantastik" };
            Tur tur3 = new Tur { TurAd = "Komedi" };
            Tur tur4 = new Tur { TurAd = "Dram" };


            Film film1 = new Film
            {
                FilmAd = "The Lord of the Rings: The Fellowship of the Ring",
                Puan = 5,
                Turler = new List<Tur> { tur1, tur2 }
            };
            Film film2 = new Film
            {
                FilmAd = "Silver Linings Playbook",
                Puan = 4,
                Turler = new List<Tur> { tur3, tur4 }
            };
            Film film3 = new Film
            {
                FilmAd = "The Addams Family",
                Puan = 3,
                Turler = new List<Tur> { tur2, tur3 }
            };
            context.Turler.AddRange(new Tur[] { tur1, tur2, tur3, tur4 });
            context.Filmler.AddRange(new Film[] { film1, film2, film3 });
        }
    }
}
