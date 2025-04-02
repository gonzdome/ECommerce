namespace ECommerce.IntegrationAPI.DTO.DTOMapping;

public static class IntegrationDTOMappingExtension
{
    public static IntegrationDTO MapToIntegrationDTO(this Integration integration)
    {
        if (integration == null)
            return null;

        return new IntegrationDTO()
        {
            Id = integration.Id,
            Name = integration.Name,
            Flow = integration.Flow,
            Uri = integration.Uri,
            CreatedAt = integration.CreatedAt,
            UpdatedAt = integration.UpdatedAt,
            Active = integration.Active,
            Excluded = integration.Excluded,
        };
    }

    public static Integration MapToIntegration(this IntegrationDTO integrationDTO)
    {
        if (integrationDTO == null)
            return null;

        return new Integration()
        {
            Id = integrationDTO.Id,
            Name = integrationDTO.Name,
            Flow = integrationDTO.Flow,
            Uri = integrationDTO.Uri,
            CreatedAt = integrationDTO.CreatedAt,
            UpdatedAt = integrationDTO.UpdatedAt,
            Active = integrationDTO.Active,
            Excluded = integrationDTO.Excluded,
        };
    }
}
