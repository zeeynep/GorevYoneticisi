namespace GorevYoneticisiAPI.Models
{
    public class User:BaseEntity
    {
        public string Username { get; set; } = string.Empty;
        public byte[] PasswordHash { get; set; } = new byte[32];
        public byte[] PasswordSalt { get; set; } = new byte[32];
        public List<Task>? Tasks { get; set; }
    }
}
