using BlazorInputFile;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Models
{
    public interface IFileUpload
    {
        Task UploadAsync(IFileListEntry file);
    }
}
