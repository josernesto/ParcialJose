using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParcialFriend.Models
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
       [Required]
        public int Name { get; set; }
    
    }
}