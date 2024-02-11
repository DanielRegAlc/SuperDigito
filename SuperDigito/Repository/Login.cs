
using Microsoft.EntityFrameworkCore;
using SuperDigito.Data;

namespace SuperDigito.Repository
{
    public class Login : ILoginRepository
    {
        private readonly ApplicationDbContext _context;

        public Login(ApplicationDbContext context)
        {
            _context = context;
        }

        async Task<Models.Login> ILoginRepository.CreateLogin(Models.Login createLogin)
        {
            if (createLogin != null)
            {
                await _context.Login.AddAsync(createLogin);
                await _context.SaveChangesAsync();
                return createLogin;
            }
            else
            {
                return new Models.Login();
            }
        }

        async Task ILoginRepository.DeleteLogin(int userId)
        {
            var userDb = await _context.Login.FindAsync(userId);
            _context.Remove(userDb);
            await _context.SaveChangesAsync();  
        }

        async Task<Models.Login> ILoginRepository.GetLogin(string userId)
        {
            var userDb = await _context.Login.FindAsync(userId);
            if (userDb == null)
                return new Models.Login();
            return userDb;
        }

        Task<List<Models.Login>> ILoginRepository.GetLogins()
        {
            return _context.Login.ToListAsync();
        }

        async Task<Models.Login> ILoginRepository.UpdateLogin(int userId, Models.Login updateLogin)
        {
            var loginDb = await _context.Login.FindAsync(userId);
            loginDb.User = updateLogin.User;
            loginDb.Password = updateLogin.Password;

            await _context.SaveChangesAsync();
            return loginDb;
        }
    }
}
