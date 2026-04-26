using System.ComponentModel.DataAnnotations;

namespace xTestAutoMapper.Models.Entities
{
    /// <summary>
    /// Sample Entity Class ...
    /// </summary>
    public class Person
    {
        [Required]
        public Guid Id { get; set; }

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;
    }
}