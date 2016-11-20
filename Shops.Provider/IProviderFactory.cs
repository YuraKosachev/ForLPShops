using Shops.Provider.Interfaces;


namespace Shops.Provider
{
    public interface IProviderFactory
    {
        IProductProvider ProductsProvider { get; }
        IShopProvider ShopsProvider { get; }
    }
}
