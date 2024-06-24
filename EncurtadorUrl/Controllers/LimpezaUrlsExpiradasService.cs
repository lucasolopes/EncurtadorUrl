
using EncurtadorUrl.Services.Interfaces;

namespace EncurtadorUrl.Controllers
{
    public class LimpezaUrlsExpiradasService : IHostedService, IDisposable
    {
        private readonly IServiceScopeFactory _scopeFactory;
        private readonly IEncurtadorService _encurtadorService;
        private Timer _timer;

        public LimpezaUrlsExpiradasService(IServiceScopeFactory scopeFactory, IEncurtadorService encurtadorService)
        {
            _scopeFactory = scopeFactory;
            _encurtadorService = encurtadorService;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            _timer = new Timer(VerificarUrlsExpiradas, null, TimeSpan.Zero, TimeSpan.FromHours(12)); // Verifica a cada 12 horas
            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            _timer?.Change(Timeout.Infinite, 0);
            return Task.CompletedTask;
        }

        private void VerificarUrlsExpiradas(object state)
        {
            using (var scope = _scopeFactory.CreateScope())
            {
               
                _encurtadorService.DeleteExpiredUrls();
            }
        }

        public void Dispose()
        {
            _timer?.Dispose();
        }
    }
}
