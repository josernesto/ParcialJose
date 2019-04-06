using System.ComponentModel.DataAnnotations;

namespace APIParcialFriend.Models
{
    public enum FriendType
    {
        Conocido,//0
        CompañeroEstudio,//1
        ColegaDeTrabajo,//2
        Amigo,//3
        AmigoDeInfancia,//4
        Pariente//5

    }


    public class JoseCalvimontesFriend
    {
        public string NickName  { get; set; }
        

        public int Birthdate { get; set; }
        [Key]
        public int FriendId { get; set; }
        [Required]
        public string Name { get; set; }
       
        [Required]
        public FriendType Type { get; set; }

      

    }
}