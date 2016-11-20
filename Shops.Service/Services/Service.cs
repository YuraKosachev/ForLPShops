using Shops.Provider;

namespace Shops.Service.Services
{
    public abstract class Service
    {
        public IProviderFactory Provider { get; set; }
        public Service()
        {
            Provider = new ProviderFactory();
        }

    }
}
