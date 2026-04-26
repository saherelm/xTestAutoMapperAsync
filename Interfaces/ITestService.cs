using xTestAutoMapper.Models.Dtos;
using xTestAutoMapper.Models.Entities;

namespace xTestAutoMapper.Interfaces
{
    public interface ITestService
    {
        Person GeneratePerson();
        PersonDto GeneratePersonDto();

        Person ToPerson(PersonDto source);
        PersonDto ToPersonDto(Person source);
    }
}