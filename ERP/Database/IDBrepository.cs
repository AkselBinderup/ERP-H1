namespace ERP;

public interface IDBrepository<T>
{
    bool Create(T obj);
    List<T> Read();
    bool Update(T obj);
    bool Delete(int obj);
}
