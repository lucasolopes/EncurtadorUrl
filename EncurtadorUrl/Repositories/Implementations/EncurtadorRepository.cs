using EncurtadorUrl.Data.Context;
using EncurtadorUrl.Repositories.Interfaces;

namespace EncurtadorUrl.Repositories.Implementations
{
    public class EncurtadorRepository : IEncurtadorRepository
    {
        private readonly EncurtadorContext _context;


        public EncurtadorRepository(EncurtadorContext context)
        {
            _context = context;
        }
        
        public void AddShorLink(string link, string shortLink, DateTime dateTime)
        {
            _context.Add(new EncurtadorUrl.Models.Entities.Encurtador
            {
                link = link,
                shortUrl = shortLink,
                dateTime = dateTime
            });
            _context.SaveChanges();
        }

        public List<string> GetAll()
        {
            return _context.Encurtadors.Select(e => e.shortUrl).ToList();
        }
    }
}
