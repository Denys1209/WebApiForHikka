﻿using TypeGen.Core.TypeAnnotations;
using WebApiForHikka.Dtos.Dto.WithoutSeoAddition.UserSettings;
using WebApiForHikka.Dtos.Shared;

namespace WebApiForHikka.Dtos.Dto.Users;

[ExportTsInterface]
public class GetUserDto : ModelDto
{
    public required GetUserSettingDto UserSetting { get; set; }
    public required string Email { get; set; }
    public required string[] Roles { get; set; }

    public required string Name { get; set; }

    public string? AvatarUrl { get; set; }

    public string? BackdropUrl { get; set; }

    public string? Description { get; set; }

    public string? StatusText { get; set; }

    public required string StatusIcon { get; set; }

    public bool AllowAdult { get; set; }

    public DateTime LastSeenAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime CreatedAt { get; set; }
}