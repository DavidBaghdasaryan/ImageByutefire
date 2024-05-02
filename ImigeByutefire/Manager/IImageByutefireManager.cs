using ImageByutefire.Models;
using ImageByutefire.Request;
using ImageByutefire.Response;
using System.Threading.Tasks;

namespace ImageByutefire.Manager
{
    public interface IImageByutefireManager
    {
        Task<ImagebyutefireResponse> AddImage(ImageByutefireRequest imageByutefireModel);
        Task<ImagebyutefireResponse> RemoveImage(ImageByutefireRequest imageByutefireModel);
    }
}
