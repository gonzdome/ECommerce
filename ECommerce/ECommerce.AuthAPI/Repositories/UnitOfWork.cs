namespace ECommerce.AuthAPI.Repositories;

public class UnitOfWork : IUnitOfWork
{
    public AppDbContext _context;
    private IUserRepository? _userRepository;
    private ICategoryRepository? _categoryRepository;

    public UnitOfWork(AppDbContext context)
    {
        _context = context;
    }

    public IUserRepository UserRepository
    {
        get { return _userRepository = _userRepository ?? new UserRepository(_context); }
    }

    public ICategoryRepository CategoryRepository
    {
        get { return _categoryRepository = _categoryRepository ?? new CategoryRepository(_context); }
    }

    public async Task Commit()
    {
        _context.SaveChanges();
    }

    public async Task Dispose()
    {
        _context.Dispose();
    }
}
