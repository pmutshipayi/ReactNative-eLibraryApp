using System.Threading.Tasks;

namespace ILabrary.Services.Libraries
{
    public interface ILibrarySessionService
    {
        Task<bool> IsAuthentificateAsync();
        int GetCurrentLibraryId();
        string GetCurrentLibraryUniqueId();
    }
}