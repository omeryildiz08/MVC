using Repositories.Contracts;

namespace Repositories
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _repositoryContext;

        public RepositoryManager(IProductRepository productRepository, RepositoryContext repositoryContext)
        {
            _productRepository = productRepository;
            _repositoryContext = repositoryContext;
        }
        

        private readonly IProductRepository _productRepository;

        public RepositoryManager(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        IProductRepository IRepositoryManager.Product => _productRepository;

        void IRepositoryManager.Save()
        {
            _repositoryContext.SaveChanges();
        }
    }
}