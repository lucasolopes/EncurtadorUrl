using EncurtadorUrl.Repositories.Implementations;
using EncurtadorUrl.Repositories.Interfaces;
using EncurtadorUrl.Services.Interfaces;
using System.Text;
using System.Xml;

namespace EncurtadorUrl.Services.Implementations
{
    public class EncurtadorService : IEncurtadorService
    {
         private readonly IEncurtadorRepository _encurtadorRepository;

         public EncurtadorService(IEncurtadorRepository encurtadorRepository)
         {
             _encurtadorRepository = encurtadorRepository;
         }


         public string CreateShortLink(string link)
         {
             string shortLink = generateShortLink(link);
             _encurtadorRepository.AddShorLink(link, shortLink, DateTime.Now);
             return shortLink;
         }

        public List<string> GetShortLinks()
        {
            return _encurtadorRepository.GetAll();
        }

        private string generateShortLink(string link)
         {

             const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
             //generate random hash with random length between 5 and 10 characters 
             Random random = new Random();
             int length = random.Next(5, 10);
             StringBuilder shortLink = new StringBuilder();
             for (int i = 0; i < length; i++)
             {
                 shortLink.Append(chars[random.Next(chars.Length)]);
             }
             return shortLink.ToString();
         }
    }
}
