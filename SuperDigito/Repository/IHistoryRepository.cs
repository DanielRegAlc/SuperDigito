using SuperDigito.Models;

namespace SuperDigito.Repository
{
    public interface IHistoryRepository
    {
        public Task<List<Models.History>> GetHistoriesByUser(int userId);
        public Task<Models.History> CreateHistory(Models.History createLogin);
        public Task DeleteHistoriesByUser(int userId);
        public Task DeleteHistory(int historyId);
    }
}
