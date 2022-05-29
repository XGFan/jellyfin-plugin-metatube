using MediaBrowser.Controller.Entities.Movies;
using MediaBrowser.Controller.Providers;
using MediaBrowser.Model.Entities;
#if !__EMBY__
using MediaBrowser.Model.Providers;
#endif

namespace Jellyfin.Plugin.JavTube.ExternalIds;

public class MovieExternalId : IExternalId
{
#if __EMBY__
    public string Name => Constant.JavTube;
#else
    public string ProviderName => Constant.JavTube;

    public ExternalIdMediaType? Type => ExternalIdMediaType.Movie;
#endif
    public string Key => Constant.JavTube;

    public string UrlFormatString => Plugin.Instance.Configuration.Server+"/r/{0}";

    public bool Supports(IHasProviderIds item)
    {
        return item is Movie;
    }
}