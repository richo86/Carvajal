using BlazorInputFile;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using System.Threading.Tasks;


namespace Proyecto.Models
{
    public class FileUpload : IFileUpload
    {
        private readonly IWebHostEnvironment _environment;
        public FileUpload(IWebHostEnvironment environment)
        {
            _environment = environment;
        }
        public async Task UploadAsync(IFileListEntry file)
        {
            var path = Path.Combine(_environment.ContentRootPath + "/wwwroot/", "images", file.Name);
            var ms = new MemoryStream();
            await file.Data.CopyToAsync(ms);
            using(FileStream fileS = new FileStream(path,FileMode.Create, FileAccess.Write))
            {
                ms.WriteTo(fileS);
            }
        }
    }
}
