using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

namespace WAD_T2104E_LeKhaDucAnh.Models
{
    public class Product
    {
        [Key] public int ProductID { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "Name must be Required!")]
        [StringLength(32, MinimumLength = 3, ErrorMessage = "Length of Name must be between 3-32")]
        public string Name { get; set; }


        [Display(Name = "Price")]
        [Required(ErrorMessage = "Price must be Required!")]
        [RegularExpression(@"^\$?([1-9]{1}[0-9]{0,2}(\,[0-9]{3})*(\.[0-9]{0,2})?|[1-9]{1}[0-9]{0,}(\.[0-9]{0,2})?|0(\.[0-9]{0,2})?|(\.[0-9]{1,2})?)$", ErrorMessage = "Price must be a Number.")]
        public long Price { get; set; }

        [Display(Name = "Quantity")]
        [Required(ErrorMessage = "Quantity must be Required!")]
        [Range(0, 100, ErrorMessage = "Quantity must be between 1-100")]
        public int Quantity { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }
        public int CategoryId { get; set; }
        public virtual Category categories { get; set; }
    }
}