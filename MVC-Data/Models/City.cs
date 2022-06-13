using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVC_Data.Models
{
    public class City
    {
        [Key]
        public string Name { get; set; }

        //[Required]
        public List<Person> People { get; set; }
    }
}
