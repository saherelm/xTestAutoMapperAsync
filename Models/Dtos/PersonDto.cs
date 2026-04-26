namespace xTestAutoMapper.Models.Dtos
{
    public class PersonDto
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;
    }
}