﻿using TypeGen.Core.TypeAnnotations;
using WebApiForHikka.Dtos.Dto.SeoAdditions;

namespace WebApiForHikka.Dtos.Shared;

[ExportTsInterface(OutputDir = "./../admin-panel-hikka/models/Shared/")]
public class UpdateDtoWithSeoAddition : ModelDto
{
    public required UpdateSeoAdditionDto SeoAddition { get; set; }
}