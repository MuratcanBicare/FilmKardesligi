using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace FilmKardesligi.Models
{
    [Table("Filmler")]
    public class Film
    {
        [Column(Order = 1)]
        public int Id { get; set; }

        [Column("Derece")]
        public int Puan { get; set; }

        [Required, MaxLength(200), Column(Order = 2)]
        public string FilmAd { get; set; }

        //[NotMapped] //veritabanında oluşmaz sadece class da kalır

        public string Kunye 
        { get 
            { 
                return $"{Utilities.Yildizla(Puan)} {FilmAd}" + 
                    $" ({Turler.Select(x => x.TurAd).Virgulle()})"; 
            } 
        }


        public virtual ICollection<Tur> Turler { get; set; }
    }
}
