using Azure.Storage.Blobs;
using Microsoft.AspNetCore.Http;
using System.IO;
using System.Threading.Tasks;

namespace PamasolaSimpleERP.Services
{
    public class ImageService
    {
        private readonly BlobServiceClient _blobServiceClient;

        public ImageService(BlobServiceClient blobServiceClient)
        {
            _blobServiceClient = blobServiceClient;
        }

        public async Task<string> UploadImageAsync(IFormFile imageFile)
        {
            // Get a reference to a container.
            BlobContainerClient containerClient = _blobServiceClient.GetBlobContainerClient("images");

            // Ensure that the container exists
            await containerClient.CreateIfNotExistsAsync();

            // Create a unique name for the image
            string fileName = Guid.NewGuid().ToString() + Path.GetExtension(imageFile.FileName);

            // Get a reference to a blob
            BlobClient blobClient = containerClient.GetBlobClient(fileName);

            // Upload the image
            using (var stream = imageFile.OpenReadStream())
            {
                await blobClient.UploadAsync(stream);
            }

            // Return the URI to the uploaded image
            return blobClient.Uri.ToString();
        }
    }
}