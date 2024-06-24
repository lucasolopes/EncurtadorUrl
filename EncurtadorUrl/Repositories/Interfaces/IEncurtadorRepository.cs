
namespace EncurtadorUrl.Repositories.Interfaces
{
    public interface IEncurtadorRepository
    {
        void AddShorLink(string link, string shortLink, DateTime dateTime, DateTime dataExpiracao);
        void DeleteExpiredUrls();
        List<string> GetAll();
        string? GetOriginalUrl(string urlEncurtada);
    }
}
