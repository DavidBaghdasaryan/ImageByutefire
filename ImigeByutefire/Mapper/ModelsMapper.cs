using AutoMapper;
using ImageByutefire.Models;
using ImageByutefire.Request;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ImageByutefire.Mapper
{
    public class ModelsMapper : Profile
    {
        public ModelsMapper()
        {
            CreateMap<ImageByutefireRequest, ImageByutefireModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Guid))
                .ForMember(dest => dest.Image, opt => opt.MapFrom(src => src.Image))
                .ForMember(dest => dest.Effect , opt => opt.MapFrom(src => src.Effect))
                .ForMember(dest => dest.Hight , opt => opt.MapFrom(src => src.Hight))
                .ForMember(dest => dest.Width , opt => opt.MapFrom(src => src.Width))
                .ForMember(dest => dest.Radious, opt => opt.MapFrom(src => src.Radious));
            CreateMap<ImageByutefireModel, ImageByutefireRequest>()
               .ForMember(dest => dest.Guid, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Image, opt => opt.MapFrom(src => src.Image))
                .ForMember(dest => dest.Effect, opt => opt.MapFrom(src => src.Effect))
                .ForMember(dest => dest.Hight, opt => opt.MapFrom(src => src.Hight))
                .ForMember(dest => dest.Width, opt => opt.MapFrom(src => src.Width))
                .ForMember(dest => dest.Radious, opt => opt.MapFrom(src => src.Radious));
        }
    }
}
