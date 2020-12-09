using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BooklistRazor.Model
{
    public class Book
    {
        [Key] //This indicates that this attribute is the key for the relation/table
        public int Id { get; set; }

        [Required] //this indicates that this attribute in the relation cannot be null.
        public int Name { get; set; }

        public string Author { get; set; }
    }
}