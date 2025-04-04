﻿namespace ECommerce.AuthAPI.Models.Entities;

public class CommonModelData
{
    public Guid Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public bool Active { get; set; } = true;
    public bool Excluded { get; set; } = false;
}
