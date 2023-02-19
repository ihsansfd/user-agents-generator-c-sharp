namespace Opapps.Lib.UserAgentsGenerator.Helpers
{
    public interface IUserAgentsRepository
    {
        public Task<List<string>> GetAllAsync();
    }
}