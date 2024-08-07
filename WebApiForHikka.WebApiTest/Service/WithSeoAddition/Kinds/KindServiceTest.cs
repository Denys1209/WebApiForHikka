﻿using WebApiForHikka.Application.WithSeoAddition.Kinds;
using WebApiForHikka.Domain.Models.WithSeoAddition;
using WebApiForHikka.EfPersistence.Data;
using WebApiForHikka.EfPersistence.Repositories.WithSeoAddition;
using WebApiForHikka.SharedModels.Models.WithSeoAddtion;
using WebApiForHikka.Test.Shared.Service;

namespace WebApiForHikka.Test.Service.WithSeoAddition.Kinds;

public class KindServiceTest : SharedServiceTestWithSeoAddition<Kind, KindService>
{
    protected override Kind GetSample()
    {
        return GetKindModels.GetSample();
    }

    protected override Kind GetSampleForUpdate()
    {
        return GetKindModels.GetSampleForUpdate();
    }

    protected override KindService GetService(HikkaDbContext hikkaDbContext)
    {
        KindRepository repository = new(hikkaDbContext);

        return new KindService(repository);
    }
}