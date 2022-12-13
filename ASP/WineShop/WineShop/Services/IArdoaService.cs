

using WineShop.Models;

namespace WineShop.Services
{
    public interface IArdoaService
    {
        Task<Ardoa> GetArdoa(int id);
        Task<IList<ArdoaUpeltegi>> GetMota(int id);
        Task<List<Ardoa>> GetArdoak();
    }
}
