using System.Data.Entity;

namespace ParcialFriend.Models
{
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<ParcialFriend.Models.JoseCalvimontesFriend> JoseCalvimontesFriends { get; set; }
    }
}