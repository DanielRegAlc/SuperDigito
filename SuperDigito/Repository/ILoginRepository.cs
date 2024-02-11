namespace SuperDigito.Repository
{
    public interface ILoginRepository
    {
        public Task<List<Models.Login>> GetLogins();
        public Task<Models.Login> GetLogin(string user);
        public Task<Models.Login> CreateLogin(Models.Login createLogin);
        public Task<Models.Login> UpdateLogin(int userId, Models.Login updateLogin);
        public Task DeleteLogin(int userId);
    }
}
