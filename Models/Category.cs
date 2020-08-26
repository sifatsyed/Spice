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
        [Required]
        public string Name { get; set; }
    }
}
