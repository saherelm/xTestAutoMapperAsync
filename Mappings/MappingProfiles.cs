using AutoMapper;
using xTestAutoMapper.Models.Dtos;
using xTestAutoMapper.Models.Entities;

namespace xTestAutoMapper.Mappings
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            //
            // Entity to Dto ...
            CreateMap<Person, PersonDto>()
                .AfterMap(async (source, dest) =>
                {
                    dest.LastName = await Task.FromResult(source.FirstName);
                });



            //
            // Dto to Entity ...
            CreateMap<PersonDto, Person>();
        }
    }
}