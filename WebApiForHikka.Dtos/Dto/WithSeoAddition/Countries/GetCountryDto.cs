﻿using TypeGen.Core.TypeAnnotations;
using WebApiForHikka.Dtos.Shared;

namespace WebApiForHikka.Dtos.Dto.WithSeoAddition.Countries;

[ExportTsInterface]
public class GetCountryDto : GetDtoWithSeoAddition
{
    public required string Name { get; set; }
    public required string Icon { get; set; }
}