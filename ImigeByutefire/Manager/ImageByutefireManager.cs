using AutoMapper;
using ImageByutefire.Models;
using ImageByutefire.Request;
using ImageByutefire.Response;
using ImageByutefire.StaticEntities;

namespace ImageByutefire.Manager
{
    public class ImageByutefireManager:IImageByutefireManager
    {
        private readonly IMapper _mapper;
        public ImageByutefireManager(IMapper mapper)
        {
            _mapper = mapper;
        }
        public async Task<ImagebyutefireResponse> AddImage(ImageByutefireRequest imageByutefireModel)
        {
            ImagebyutefireResponse  imagebyutefireResponse = new();
            StaticImagesList.ImagesList = new();
            ImageByutefireModel imageByutefireModel1 = _mapper.Map<ImageByutefireModel>(imageByutefireModel);
            imageByutefireModel1.Id=new Guid();
            StaticImagesList.ImagesList.Add(imageByutefireModel1);
            imagebyutefireResponse.Massege = "Ok";
            return imagebyutefireResponse;
        }
        public async Task<ImagebyutefireResponse> RemoveImage(ImageByutefireRequest imageByutefireModel)
        {
            ImagebyutefireResponse imagebyutefireResponse = null;
            ImageByutefireModel imageByutefireModel1 = _mapper.Map<ImageByutefireModel>(imageByutefireModel);
            var checkitem= StaticImagesList.ImagesList.FirstOrDefault(x => x.Id==imageByutefireModel1.Id);
            if (checkitem != null)
            {
                StaticImagesList.ImagesList.Remove(imageByutefireModel1);
                imagebyutefireResponse.Massege = "Ok";
            }
            else
                imagebyutefireResponse.Massege = "Image Not Found";
            return imagebyutefireResponse;
        }
    }
}
