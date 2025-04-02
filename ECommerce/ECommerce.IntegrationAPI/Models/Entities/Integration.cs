namespace ECommerce.IntegrationAPI.Models.Entities;

public class Integration : CommonModelData
{
    [MinLength(3)]
    [MaxLength(100)]
    public string Name { get; set; }

    [MinLength(3)]
    [MaxLength(300)]
    public string Flow { get; set; }

    [MinLength(3)]
    [MaxLength(500)]
    public string Uri { get; set; }
}
