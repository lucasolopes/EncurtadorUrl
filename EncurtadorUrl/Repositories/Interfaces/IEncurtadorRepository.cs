
namespace EncurtadorUrl.Repositories.Interfaces
{
    public interface IEncurtadorRepository
    {
        void AddShorLink(string link, string shortLink, DateTime dateTime);
        List<string> GetAll();
        string? GetOriginalUrl(string urlEncurtada);
    }
}
