using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Product

    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength: 55)]
        public string Name { get; set; }
        public int Price { get; set; }
        public int OldPrice { get; set; }
        [StringLength(maximumLength: 50)]
        public string MainiIcon { get; set; }
        [StringLength(maximumLength: 50)]
        public string LikeIcon { get; set; }
        [StringLength(maximumLength: 50)]
        public string ViewIcon { get; set; }
        [StringLength(maximumLength: 100)]
        public string Image { get; set; }


    }
} 
