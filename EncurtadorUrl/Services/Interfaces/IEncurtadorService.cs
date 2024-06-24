namespace EncurtadorUrl.Services.Interfaces
{
    public interface IEncurtadorService
    {
        string CreateShortLink(string link);
        void DeleteExpiredUrls();
        List<string> GetShortLinks();
        string? ObterUrlOriginal(string urlEncurtada);
    }
}
