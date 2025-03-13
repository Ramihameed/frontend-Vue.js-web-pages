namespace Test_3.Models
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);     // Adds a new entity
        void Remove(int id);    // Removes an entity by its ID
        void Edit(T entity);    // Edits an existing entity
        T Get(int id);          // Gets an entity by its ID
        IEnumerable<T> GetAll(); // Optionally, to get all entities
    }
}
