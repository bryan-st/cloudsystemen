using FashionClub.Core.Application.DTOs;

namespace FashionClub.Core.Application.Abstractions.Services;

public interface IKlantenService
{
    Task<KlantenResponseDTO> GetKlantByName(string searchName,int page,int pageSize);

    Task<List<ShopDTO>> GetKlantShopsById(long klantId);
}