using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.IO;

namespace MoviePro.Services
{
    public class BasicImageService : IImageService
    {
        public string DecodePoster(byte[] poster, string contentType)
        {
            if (poster == null)
            {
                return null;
            }

            var posterImage = Convert.ToBase64String(poster);
            return $"data:{contentType};base64,{posterImage}";
        }

        public async Task<byte[]> EncodeImageURLAsync(string imageURL)
        {
            var client = new HttpClient();
            //Allows us to pass something as a URL and get a response

            var response = await client.GetAsync(imageURL);

            Stream stream = await response.Content.ReadAsStreamAsync();
            var ms = new MemoryStream();
            await stream.CopyToAsync(ms);

            return ms.ToArray();
            //sets base64 to an image tag

        }

        public async Task<byte[]> EncodePosterAsync(IFormFile poster)
        {
            if (poster == null)
            {
                return null;
            }
            using var ms = new MemoryStream();
            await poster.CopyToAsync(ms);
            return ms.ToArray();
        }

        public string RecordContentType(IFormFile poster)
        {
            if (poster == null)
            {
                return null;
            }
            return poster.ContentType;
            //compares content Type

        }
    }
}
