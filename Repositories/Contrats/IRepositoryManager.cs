namespace Repositories.Contrats
{
    public interface IRepositoryManager
    {
        IProductRepository Product {get; }
        ICategoryRepository Category {get; }
        IOrderRepository Order {get; }
        void Save();
    }
}