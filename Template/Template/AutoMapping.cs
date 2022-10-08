using AutoMapper;

namespace Template
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<ExampleObjectDto, ExampleObject>();
        }
    }
}
