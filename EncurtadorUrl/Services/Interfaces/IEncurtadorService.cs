namespace EncurtadorUrl.Services.Interfaces
{
    public interface IEncurtadorService
    {
        string CreateShortLink(string link);
        List<string> GetShortLinks();
        string? ObterUrlOriginal(string urlEncurtada);
    }
}
