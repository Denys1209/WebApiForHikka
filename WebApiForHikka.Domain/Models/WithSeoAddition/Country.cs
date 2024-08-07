﻿using System.ComponentModel.DataAnnotations;
using WebApiForHikka.Constants.Models.WithSeoAddition.Countries;

namespace WebApiForHikka.Domain.Models.WithSeoAddition;

public class Country : ModelWithSeoAddition
{
    [StringLength(CountryNumberConstants.NameLength)]
    public required string Name { get; set; }

    [StringLength(CountryNumberConstants.IconLength)]
    public required string Icon { get; set; }

    public virtual ICollection<Anime> Animes { get; } = [];
}