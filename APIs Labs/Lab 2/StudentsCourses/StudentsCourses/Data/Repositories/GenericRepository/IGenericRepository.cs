namespace StudentsCourses.Data.Repositories.GenericRepository
{
    public interface IGenericRepository<TEntity>
    {
        List<TEntity> GetAll();
        TEntity? GetById(Guid id);
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        void SaveChanges();

    }
}
