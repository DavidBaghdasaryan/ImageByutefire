using ImageByutefire.Manager;
using ImageByutefire.Request;
using Microsoft.AspNetCore.Mvc;

namespace ImageByutefire.Controllers
{
    public class ImageByutefireController : Controller
    {
        IImageByutefireManager imageByutefireManager;
        public ImageByutefireController(IImageByutefireManager _imageByutefireManager)
        {
            imageByutefireManager = _imageByutefireManager;
        }

        [HttpPost("AddImage")]
        public async Task<IActionResult> AddImage([FromQuery] ImageByutefireRequest request)
        {

             var res=  await imageByutefireManager.AddImage(request);

            return Ok(res);
        }
        [HttpPost("DeleteImage")]
        public async Task<IActionResult> DeleteImage([FromQuery] ImageByutefireRequest request)
        {

            var res = await imageByutefireManager.RemoveImage(request);

            return Ok(res);
        }
    }
}
