namespace EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Domain.IRepositories
{
    /// <summary>
    /// This is the interface for repository method
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepository<T>
    {
        public T[] Items { get;} // property 
        T[] GetAllItems(); // method
    }
}