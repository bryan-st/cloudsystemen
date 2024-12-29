namespace FashionClub.Core.Application.DTOs;


public record KlantDTO(long Id, string Name, AddressDTO Address);

public record KlantenResponseDTO(List<KlantDTO> Klanten, int Pages);
