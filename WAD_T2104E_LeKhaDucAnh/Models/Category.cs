using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WAD_T2104E_LeKhaDucAnh.Models
{
    public class Category
    {
        [Key] public int CategoryId { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "Name must be Required!")]
        public string CategoryName { get; set; }

        public virtual ICollection<Product> products {get; set;}
    }
}