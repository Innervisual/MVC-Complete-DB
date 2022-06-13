using System.ComponentModel.DataAnnotations;

namespace MVC_Data.Models
{
    public class PersonLanguage
    {
        [Key]
        public string PersonName { get; set; }
        public string LanguageName { get; set; }


        public Person Person { get; set; }
        public Language Language { get; set; }
    }
}
 