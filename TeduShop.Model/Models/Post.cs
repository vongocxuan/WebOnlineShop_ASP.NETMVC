using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Model.Abstract;

namespace TeduShop.Model.Models
{
    [Table("Posts")]
    public class Post: Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        [MaxLength(250)]
        [Required]
        public string Name { set; get; }
        [Required]
        [MaxLength(250)]
        [Column(TypeName ="varchar")]
        public string Alias { set; get; }
        public int CategoryID { set; get; }
        [MaxLength(500)]
        public string Image { set; get; }
        [MaxLength(500)]
        public string Description { set; get; }
        public string Content { set; get; }
        public bool? HomeFlag { set; get; }
        public bool? HotFlag { set; get; }
        public bool? ViewCount { set; get; }
        [ForeignKey("CategoryID")]
        public virtual PostCategory PostCategory { set; get; }
    }
}
