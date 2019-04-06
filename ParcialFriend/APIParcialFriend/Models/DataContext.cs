using System.Data.Entity;

namespace APIParcialFriend.Models
{
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        
    }
}