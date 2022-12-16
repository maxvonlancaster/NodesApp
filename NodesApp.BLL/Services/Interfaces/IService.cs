namespace NodesApp.BLL.Services.Interfaces
{
    public interface IService<T>
    {
        public T Get(long id);
        public IEnumerable<T> Get(Predicate<T> condition);
        public long Add(T entity); // return id of added row in db
        public int Update(IEnumerable<T> entity); // return number of updates in db
        public void Delete(long id);
    }
}
