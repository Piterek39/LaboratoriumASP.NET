using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostData.Entities
{
    [Table("posts")]
    public class PostEntity
    {
        [Column("id")]
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        [Required]
        public string Content { get; set; }
        [MaxLength(50)]
        [Required]
        public string Autor { get; set; }
        [Column("postdate")]
        public DateTime PostDate { get; set; }
        public string Tag { get; set; }
        public string Comment { get; set; }

    }
}
