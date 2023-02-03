namespace DocGenSample
{
    public interface IUserManager
    {
        User GetUser(string username);

        Task<User> GetUserAsync(string username);

        bool StoreUser(User user);

        Task<bool> StoreUserAync(User user);
    }
}
