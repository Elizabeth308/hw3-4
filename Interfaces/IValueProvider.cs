
namespace homework3_4.Interfaces
{    
    public interface IValueProvider<T>
    {
        T GetRandomValue();
        T GetUserValue();
    }
}