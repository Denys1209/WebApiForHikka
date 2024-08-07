﻿using Faker;
using WebApiForHikka.Domain.Models.WithSeoAddition;
using WebApiForHikka.Dtos.Dto.WithSeoAddition.Formats;
using WebApiForHikka.SharedModels.Models.WithoutSeoAddition;

namespace WebApiForHikka.SharedModels.Models.WithSeoAddtion;

public static class GetFormatModels
{
    public static Format GetSample()
    {
        return new Format
        {
            Name = "test",
            SeoAddition = GetSeoAdditionModels.GetSample()
        };
    }

    public static Format GetSampleForUpdate()
    {
        return new Format
        {
            Name = "test1",
            SeoAddition = GetSeoAdditionModels.GetSampleForUpdate()
        };
    }

    public static CreateFormatDto GetCreateDtoSample()
    {
        return new CreateFormatDto
        {
            Name = Lorem.GetFirstWord(),
            SeoAddition = GetSeoAdditionModels.GetCreateDtoSample()
        };
    }

    public static GetFormatDto GetGetDtoSample()
    {
        return new GetFormatDto
        {
            Name = Lorem.GetFirstWord(),
            SeoAddition = GetSeoAdditionModels.GetGetDtoSample(),
            Id = new Guid()
        };
    }

    public static Format GetModelSample()
    {
        return new Format
        {
            Name = Lorem.GetFirstWord(),
            SeoAddition = GetSeoAdditionModels.GetSample(),
            Id = new Guid()
        };
    }

    public static UpdateFormatDto GetUpdateDtoSample()
    {
        return new UpdateFormatDto
        {
            Name = Lorem.GetFirstWord(),
            SeoAddition = GetSeoAdditionModels.GetUpdateDtoSample(),
            Id = new Guid()
        };
    }
}