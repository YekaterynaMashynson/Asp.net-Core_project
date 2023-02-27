using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
 
namespace MyCompany.Domain.Entities
{
    public abstract class EntityBase
    {
        protected EntityBase() => DataAdded = DateTime.UtcNow;
        
        [Required]
    public Guid Id { get; set; }
        [Display(Name ="Name (title)")]
        public virtual string Title { get; set; }

        [Display(Name = "Short description")]
        public virtual string Subtitle { get; set; }

        [Display(Name = "Full description")]
        public virtual string Text { get; set; }

        [Display(Name = "Title page")]
        public virtual string TitleImagePath { get; set; }

        [Display(Name = "SEO metatag Title")]
        public virtual string MetaTable { get; set; }

        [Display(Name = "SEO metatag Description")]
        public virtual string MetaDescription { get; set; }

        [Display(Name = "SEO metatg Keywords")]
        public virtual string MetaKeywords { get; set; }

        [DataType(DataType.Time)]
        public DateTime DataAdded { get; set; }

    }
}
