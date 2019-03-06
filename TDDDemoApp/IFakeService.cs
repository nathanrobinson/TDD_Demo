using System.Threading.Tasks;

namespace TDDDemoApp
{
    public interface IFakeService
    {
         Task<int> GetValueAsync(int id);
         Task SetValueAsync(int id, int value);

         void DontCallMe();
    }
}