namespace DocGenSample
{
    /// <summary>
    /// Example of documentation for 'User' public class
    /// </summary>
    public class User
    {
        /// <summary>
        /// Unique user identifier
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Full name of the user
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Creates a new instance of User object
        /// </summary>
        /// <param name="id">Unique identifier</param>
        /// <param name="name">Full name</param>
        public User(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}