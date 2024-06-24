namespace EncurtadorUrl.Services.Interfaces
{
    public interface IEncurtadorService
    {
        string CreateShortLink(string link);
        List<string> GetShortLinks();
    }
}
