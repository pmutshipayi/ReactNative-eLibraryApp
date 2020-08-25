using Microsoft.AspNetCore.Http;

namespace ILabrary.Services
{
    public interface IFileService
    {
        string SaveFile(IFormFile file);
    }
}