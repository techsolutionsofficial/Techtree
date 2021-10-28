using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Techtree.Entities
{
    public class Content
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please Enter Title!!!")]
        [StringLength(200, MinimumLength = 2)]
        public string Title { get; set; }

        [Display(Name = "HTML Content")]
        public string HtmlContent { get; set; }

        [Display(Name = "Video Link")]
        public string VideoLink { get; set; }

        [Display(Name = "Category Item")]
        public CategoryItem CategoryItem { get; set; }

        [NotMapped]
        public int CatItemId { get; set; }

        [NotMapped]
        public int CategoryId { get; set; }
    }
}
