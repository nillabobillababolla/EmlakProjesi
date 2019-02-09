using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Emlak.Entity.Entities
{
    [Table("KatTurleri")]
    public class Kattur
    {
        [Key]
        public int ID { get; set; }

        [StringLength(15)]
        [Required]
        public string Tur { get; set; }

        public virtual List<Konut> Konutlar { get; set; } = new List<Konut>();
    }
}
