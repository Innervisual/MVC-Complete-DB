using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Data.Models
{
    public class Person
    {
        [Key]
        public string Name { get; set; }
        [Required]
        public int PhoneNumber { get; set; }
        public int Id { get; set; }

        //[Required]
        public City City { get; set; }

        public List<PersonLanguage> PersonLanguages { get; set; }

        internal bool Contains()
        {
            throw new NotImplementedException();
        }
    }

}
