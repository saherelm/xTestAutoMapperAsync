using AutoMapper;
using xTestAutoMapper.Interfaces;
using xTestAutoMapper.Models.Dtos;
using xTestAutoMapper.Models.Entities;

namespace xTestAutoMapper.Services
{
    public class TestService : ITestService
    {
        //
        private readonly IMapper mapper;

        //
        public TestService(
            IMapper mapper
        )
        {
            this.mapper = mapper;
        }

        public Person GeneratePerson()
        {
            //
            var result = new Person()
            {
                Id = Guid.NewGuid(),
                FirstName = "Hadi",
                LastName = "Khazaee Asl"
            };

            //
            return result;
        }

        public PersonDto GeneratePersonDto()
        {
            //
            var result = new PersonDto()
            {
                Id = Guid.NewGuid(),
                FirstName = "Hadi",
                LastName = "Khazaee Asl"
            };

            //
            return result;
        }

        public Person ToPerson(PersonDto source)
        {
            //
            var result = mapper.Map<Person>(source);

            //
            return result;
        }

        public PersonDto ToPersonDto(Person source)
        {
            //
            var result = mapper.Map<PersonDto>(source);

            //
            return result;
        }
    }
}