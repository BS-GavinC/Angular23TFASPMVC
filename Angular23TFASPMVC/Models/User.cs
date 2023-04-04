namespace Angular23TFASPMVC.Models
{
    public class User
    {
        public User(string email, string lastname, string firstname)
        {
            Email = email;
            Lastname = lastname;
            Firstname = firstname;
        }

        public string Email { get; set; }


        public string Lastname { get; set; }

        public string Firstname { get; set; }
    }
}
