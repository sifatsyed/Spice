using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Spice.Models
{
    public class Category
    {
        //Specifying that it is a primary key
        [Key]
        public int Id { get; set; }

        //Specifying that it is a required attribute
        //Display for changing the name of anything that has a different name in model
        [Display(Name = "Category Name")]
        [Required]
        public string Name { get; set; }
    }
}
