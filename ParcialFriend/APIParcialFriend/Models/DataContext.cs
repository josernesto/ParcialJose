using System.Data.Entity;

namespace APIParcialFriend.Models
{
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<APIParcialFriend.Models.JoseCalvimontesFriend> JoseCalvimontesFriends { get; set; }
    }
}