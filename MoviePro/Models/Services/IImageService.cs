using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace MoviePro.Services
{
    public interface IImageService
    {
        //Create "Signatures"

        //Encode an Image from an Upload Control
        Task<byte[]> EncodePosterAsync(IFormFile poster);

        //Encode an Image from a URL
        Task<byte[]> EncodeImageURLAsync(string imageURL);
        //saves to the Database, so if the Origin URL disappears, we still have the image

        string DecodePoster(byte[] poster, string contentType);
        //Pulling byte[] out of the Db and converting it into a string

        string RecordContentType(IFormFile poster);
        //

        //Write the "Concrete Class"



    }
}
