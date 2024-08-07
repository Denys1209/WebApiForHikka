﻿using WebApiForHikka.Domain.Models.WithSeoAddition;
using WebApiForHikka.EfPersistence.Data;
using WebApiForHikka.EfPersistence.Repositories.WithSeoAddition;
using WebApiForHikka.SharedModels.Models.WithSeoAddtion;
using WebApiForHikka.Test.Shared.Repository;

namespace WebApiForHikka.Test.Repository.WithSeoAddition.Formats;

public class FormatRepositoryTest : SharedRepositoryTestWithSeoAddition<
    Format,
    FormatRepository
>
{
    protected override FormatRepository GetRepository(HikkaDbContext hikkaDbContext)
    {
        return new FormatRepository(hikkaDbContext);
    }

    protected override Format GetSample()
    {
        return GetFormatModels.GetSample();
    }

    protected override Format GetSampleForUpdate()
    {
        return GetFormatModels.GetSampleForUpdate();
    }
}