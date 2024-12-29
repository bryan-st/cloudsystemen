﻿namespace FashionClub.Domain.Models;

public partial class AgeCategory
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public long UserCreatedId { get; set; }

    public DateTime DateCreated { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
