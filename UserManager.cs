namespace DocGenSample
{
    public class UserManager : IUserManager
    {
        public User GetUser(string username)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUserAsync(string username)
        {
            throw new NotImplementedException();
        }

        public bool StoreUser(User user)
        {
            throw new NotImplementedException();
        }

        public Task<bool> StoreUserAync(User user)
        {
            throw new NotImplementedException();
        }
    }
}
