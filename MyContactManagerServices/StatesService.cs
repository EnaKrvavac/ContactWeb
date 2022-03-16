using ContactWebModels;
using MyContactsManagerRepositories;

namespace MyContactManagerServices
{
    public class StatesService : IStatesService
    {
        private IStatesRepository _statesRerpository;

        public StatesService(IStatesRepository statesRepository)
        {
            _statesRerpository = statesRepository;
        }
        public async Task<IList<State>> GetAllAsync()
        {
            return await _statesRerpository.GetAllAsync();      
        }

        public async Task<State?> GetAsync(int id)
        {
            return await _statesRerpository.GetAsync(id);
        }
        public Task<int> AddOrUpdateAsync(State state)
        {
            return _statesRerpository.AddOrUpdateAsync(state);
        }

        public async Task<int> DeleteAsync(State state)
        {
            return await _statesRerpository.DeleteAsync(state);
        }

        public async Task<int> DeleteAsync(int id)
        {
            return await _statesRerpository.DeleteAsync(id);
        }

        public async Task<bool> ExistsAsync(int id)
        {
            return await _statesRerpository.ExistsAsync(id);

        }


    }
}