﻿using WebApiForHikka.Application.Shared;
using WebApiForHikka.Application.WithoutSeoAddition.EpisodeImages;
using WebApiForHikka.Domain.Models.WithSeoAddition;

namespace WebApiForHikka.Application.WithSeoAddition.Episodes;

public class EpisodeService(IEpisodeRepository repository, IEpisodeImageService episodeImageService)
    : CrudService<Episode, IEpisodeRepository>(repository), IEpisodeService
{
    public override async Task DeleteAsync(Guid id, CancellationToken cancellationToken)
    {
        var images = episodeImageService.GetEpisodeImagesForEpisode(id);

        foreach (var item in images) await episodeImageService.DeleteAsync(item.Id, cancellationToken);

        await Repository.DeleteAsync(id, cancellationToken);
    }
}