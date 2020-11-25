using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FilmKardesligi.Models
{
    [Table("Turler")]
    public class Tur
    {
        
        public int Id { get; set; }

        [Required, MaxLength(30)]
        public string TurAd { get; set; }

        public virtual ICollection<Film> Film { get; set; }
    }
}
