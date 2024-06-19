﻿using WebApiForHikka.Domain;
using WebApiForHikka.Domain.Models;

namespace WebApiForHikka.Application.Shared;

public interface ICrudService<TModel> where TModel : class, IModel
{
    Task<Guid> CreateAsync(TModel model, CancellationToken cancellationToken);
    Task UpdateAsync(TModel model, CancellationToken cancellationToken);
    Task DeleteAsync(Guid id, CancellationToken cancellationToken);
    Task<TModel?> GetAsync(Guid id, CancellationToken cancellationToken);
    TModel? Get(Guid id);
    Task<PaginatedCollection<TModel>> GetAllAsync(FilterPagination dto, CancellationToken cancellationToken);
    Task<IReadOnlyCollection<TModel?>> GetAllModelsByIdsAsync(List<Guid> ids, CancellationToken cancellationToken);
}