using System.ComponentModel.DataAnnotations;

namespace DemoApi.Core.Models
{
    public class Person
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        [Custom]
        public string LastName { get; set; }
    }
}
