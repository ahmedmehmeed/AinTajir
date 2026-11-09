using Volo.Abp.Application.Services;
using AinTajir.Localization;

namespace AinTajir.Services;

/* Inherit your application services from this class. */
public abstract class AinTajirAppService : ApplicationService
{
    protected AinTajirAppService()
    {
        LocalizationResource = typeof(AinTajirResource);
    }
}