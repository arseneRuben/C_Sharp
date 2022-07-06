using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter2
{
    enum Gender { MALE, FEMALE};
    enum ChatStatuts { ONLINE, OFFLINE, BUSY };
    class Chat
    {
        public string username;
        public Gender usergender;
        public byte userage;
        public string email;
        public ChatStatuts state;

        public Chat(string name, Gender gender, byte age, string mail, ChatStatuts statut)
        {
            username = name;
            usergender = gender;
            userage = age;
            email = mail;
            state = statut;
        }

        public static void Question3()
        {
            Chat chat = new Chat("Nanou", Gender.FEMALE, 9, "nanou@yahoo.fr", ChatStatuts.ONLINE);
            Console.WriteLine("le Chat {0} est de sexe {1} , age de {2} ans ", chat.username, chat.usergender, chat.userage);

        }



    }
}
