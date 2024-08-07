﻿using TypeGen.Core.TypeAnnotations;
using WebApiForHikka.Dtos.Shared;

namespace WebApiForHikka.Dtos.Dto.WithoutSeoAddition.Mediaplayers;

[ExportTsInterface]
public class GetMediaplayerDto : ModelDto
{
    public required string Name { get; set; }

    public required string Icon { get; set; }
}