﻿
using Microsoft.Extensions.DependencyInjection;
using WebApiForHikka.Application.Periods;
using WebApiForHikka.Application.SeoAdditions;
using WebApiForHikka.Constants.Models.Periods;
using WebApiForHikka.Domain.Models;
using WebApiForHikka.Dtos.Dto.Periods;
using WebApiForHikka.Dtos.Shared;
using WebApiForHikka.EfPersistence.Repositories;
using WebApiForHikka.Test.Controllers.Shared;
using WebApiForHikka.WebApi.Controllers.ControllersWithSeoAddition;

namespace WebApiForHikka.Test.Controllers.CrudControllers.WithSeoAddition;

public class PeriodControllerTest : CrudControllerBaseWithSeoAddition<
    PeriodController,
    PeriodService,
    Period,
    IPeriodRepository,
    UpdatePeriodDto,
    CreatePeriodDto,
    GetPeriodDto,
    ReturnPageDto<GetPeriodDto>,
    PeriodStringConstants
    >
{
    protected override AllServicesInControllerWithSeoAddition GetAllServices(IServiceCollection alternativeServices)
    {
        var dbContext = GetDatabaseContext();

        var seoAdditionRepository = new SeoAdditionRepository(dbContext);
        var formatRepository = new PeriodRepository(dbContext);
        var userManager = GetUserManager(dbContext);
        var roleManager = GetRoleManager(dbContext);

        return new AllServicesInControllerWithSeoAddition(new PeriodService(formatRepository), new SeoAdditionService(seoAdditionRepository), userManager, roleManager);
    }



    protected override async Task<PeriodController> GetController(AllServicesInController allServicesInController, IServiceProvider alternativeServices)
    {
        AllServicesInControllerWithSeoAddition allServices = allServicesInController as AllServicesInControllerWithSeoAddition ?? throw new Exception("method getController in PeriodControllerTest");

        return new PeriodController(
            allServices.CrudService,
            allServices.SeoAdditionService,
            _mapper,
            await GetHttpContextAccessForAdminUser(allServicesInController.UserManager, allServices.RoleManager)
            );
    }


    protected override CreatePeriodDto GetCreateDtoSample()
    {
        return new CreatePeriodDto()
        {
            Name = Faker.Lorem.GetFirstWord(),
            SeoAddition = GetSeoAdditionCreateDtoSample(),
        };
    }

    protected override GetPeriodDto GetGetDtoSample()
    {
        return new GetPeriodDto()
        {
            Name = Faker.Lorem.GetFirstWord(),
            SeoAddition = GetSeoAdditionGetDtoSample(),
            Id = new Guid(),
        };
    }

    protected override Period GetModelSample()
    {
        return new Period()
        {
            Name = Faker.Lorem.GetFirstWord(),
            SeoAddition = GetSeoAdditionSample(),
            Id = new Guid(),
        };
    }

    protected override UpdatePeriodDto GetUpdateDtoSample()
    {
        return new UpdatePeriodDto()
        {
            Name = Faker.Lorem.GetFirstWord(),
            SeoAddition = GetSeoAddtionUpdateDtoSample(),
            Id = new Guid(),
        };
    }
}