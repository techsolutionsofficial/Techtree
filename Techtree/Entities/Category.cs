using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Techtree.Entities
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please Enter Title!!!")]
        [StringLength(200, MinimumLength = 2)]
        public string Title { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        [Required(ErrorMessage = "Please Add Thumbnail Image!!!")]
        [Display(Name = "Thumbnail Image")]
        public string ThumbnailImage { get; set; }

        [ForeignKey("CategoryId")]
        public virtual ICollection<CategoryItem> CategoryItems { get; set; }

        [ForeignKey("CategoryId")]
        public virtual ICollection<UserCategory> UserCategories { get; set; }
    }
}
