﻿using System.ComponentModel.DataAnnotations;
using WebApiForHikka.Constants.Models.Relation.Season;
using WebApiForHikka.Domain.Models.WithoutSeoAddition;
using WebApiForHikka.Domain.Models.WithSeoAddition;

namespace WebApiForHikka.Domain.Models.Relation;

public class Season : RelationModel<Anime, AnimeGroup>
{
    [StringLength(SeasonNumberConstants.NameLength)]
    public required string Name { get; set; }
}