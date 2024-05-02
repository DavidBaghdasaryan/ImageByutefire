using ImageByutefire.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Swashbuckle.AspNetCore.Annotations;
using System.Text.Json.Serialization;

namespace ImageByutefire.Request
{
    public class ImageByutefireRequest
    {
        [BindNever]
        public Guid Guid { get; set; } 
        public string Image { get; set; }
        public Effects Effect { get; set; }
        public decimal Radious { get; set; }
        public int Hight { get; set; }
        public int Width { get; set; }
    }
}
