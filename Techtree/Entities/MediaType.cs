using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Techtree.Interfaces;

namespace Techtree.Entities
{
    public class MediaType : iPrimaryProperties
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please Enter Title!!!")]
        [StringLength(200, MinimumLength = 2)]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please Add Thumbnail Image!!!")]
        [Display(Name = "Thumbnail Image")]
        public string ThumbnailImage { get; set; }

        [ForeignKey("MediaTypeId")]
        public virtual ICollection<CategoryItem> CategoryItems { get; set; }

    }
}
