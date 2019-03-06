using System.Threading.Tasks;

namespace TDDDemoApp
{
    public class DependantService
    {
        private readonly IFakeService _fakeService;

        public DependantService(IFakeService fakeService)
        {
            _fakeService = fakeService;
        }

        public async Task<int> AddValueAsync(int id, int delta)
        {
            var currentValue = await _fakeService.GetValueAsync(id);
            currentValue += delta;
            await _fakeService.SetValueAsync(id, currentValue);
            //_fakeService.DontCallMe();
            //return currentValue + 1;
            return currentValue;
        }
    }
}