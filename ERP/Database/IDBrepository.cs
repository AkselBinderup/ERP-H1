namespace ERP;

public interface IDBrepository <T>
{
    bool Create(T obj);
    bool Read(T obj);
    bool Update(T obj);
    bool Delete(T obj);
}
