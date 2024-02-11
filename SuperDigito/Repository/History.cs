
using Microsoft.EntityFrameworkCore;
using SuperDigito.Data;
using SuperDigito.Models;

namespace SuperDigito.Repository
{
    public class History : IHistoryRepository
    {
        private readonly ApplicationDbContext _context;

        public History(ApplicationDbContext context)
        {
            _context = context;
        }

        async Task<Models.History> IHistoryRepository.CreateHistory(Models.History createHistory)
        {
            if (createHistory != null)
            {
                await _context.History.AddAsync(createHistory);
                await _context.SaveChangesAsync();
                return createHistory;
            }
            else
            {
                return new Models.History();
            }
        }

        async Task IHistoryRepository.DeleteHistoriesByUser(int userId)
        {
            var historiesList = await _context.History
                                      .Where(h => h.UserId == userId)
                                      .ToListAsync();

            foreach (var history in historiesList)
                _context.History.Remove(history);
            
            await _context.SaveChangesAsync();
        }

        async Task IHistoryRepository.DeleteHistory(int historyId)
        {
            var historyDb = await _context.History.FindAsync(historyId);
            _context.Remove(historyDb);
            await _context.SaveChangesAsync();
        }

        async Task<List<Models.History>> IHistoryRepository.GetHistoriesByUser(int userId)
        {
            var historiesListByUser = await _context.History
                                            .Where(history => history.UserId == userId)
                                            .ToListAsync();

            return historiesListByUser;
        }
    }
}
