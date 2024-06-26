﻿using Microsoft.EntityFrameworkCore;
using WebApiForHikka.Application.WithoutSeoAddition.Mediaplayers;
using WebApiForHikka.Constants.Models.Mediaplayers;
using WebApiForHikka.Domain.Models.WithoutSeoAddition;
using WebApiForHikka.EfPersistence.Data;

namespace WebApiForHikka.EfPersistence.Repositories.WithoutSeoAddition;

public class MediaplayerRepository(HikkaDbContext dbContext) : CrudRepository<Mediaplayer>(dbContext), IMediaplayerRepository
{
    protected override IQueryable<Mediaplayer> Filter(IQueryable<Mediaplayer> query, string filterBy, string filter)
    {
        return filterBy switch
        {
            MediaplayerStringConstants.NameName => query.Where(m => EF.Functions.ILike(m.Name, $"%{filter}%")),
            MediaplayerStringConstants.IconName => query.Where(m => EF.Functions.ILike(m.Icon, $"%{filter}%")),
            _ => query.Where(m => m.Id.ToString().Contains(filter)),
        };
    }

    protected override IQueryable<Mediaplayer> Sort(IQueryable<Mediaplayer> query, string orderBy, bool isAscending)
    {
        return orderBy switch
        {
            MediaplayerStringConstants.NameName => isAscending ? query.OrderBy(m => m.Name) : query.OrderByDescending(m => m.Name),
            MediaplayerStringConstants.IconName => isAscending ? query.OrderBy(m => m.Icon ?? "") : query.OrderByDescending(m => m.Icon ?? ""),
            _ => isAscending ? query.OrderBy(m => m.Id) : query.OrderByDescending(m => m.Id) // Default sorting by Id
        };
    }

    protected override void Update(Mediaplayer model, Mediaplayer entity)
    {
        DbContext.Entry(entity).CurrentValues.SetValues(model);
    }
}
