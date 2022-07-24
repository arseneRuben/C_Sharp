using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Model
{
     public enum RoleItem
    {
        USER,ADMIN,GROUP_ADMIN
    }

    public enum MessageStatus
    {
        SENT, RECEIVED,RED
    }
    public class Adress
    {
        public int Num
        {
            get; set;
        }
        public string Street {
            get; set;
        } //rue
        public string Town {
            get; set;
        }  // ville
        public int PostalCode
        {
            get; set;
        }
        public string Country
        {
            get; set;
        }

    }

    public class Contact : TimeStampableItem
    {
        public string Lastname
        {
            get; set;
        }
        public string Firstname
        {
            get; set;
        }
        public string Relation
        {
            get; set;
        }
        public Adress Adress
        {
            get; set;
        }
        public string Phone
        {
            get; set;
        }
        public string Email
        {
            get; set;
        }
    }



    interface TimeStampable
    {
        DateTime CreatedAt
        {
            get; set;
        }
        DateTime UpdatedAt
        {
            get; set;
        }

         void UpdateTimeStamp();
    }

    public  class TimeStampableItem : TimeStampable
    {
        protected int Id { get; set; }
        protected TimeStampableItem()
        {
            UpdateTimeStamp();
        }
        
        public DateTime CreatedAt
        {
            get; set;
        }

        public DateTime UpdatedAt
        {
            get; set;
        }


        public void UpdateTimeStamp()
        {
            if (this.CreatedAt == null)
            {
                this.CreatedAt = DateTime.Now;
            }

            UpdatedAt = DateTime.Now;
        }
    }

    public class User : TimeStampableItem
    {
        public String profileImage { get; set; }
        public User(string email, string password):base()
        {
           
            this.Email = email;
            this.Password = password;
            this.Roles = new List<RoleItem>();
            this.Roles.Add(RoleItem.USER);
        }
        public User(string username, string password, RoleItem r) : base()
        {

            this.Email = username;
            this.Password = password;
            this.Roles = new List<RoleItem>();
            this.Roles.Add(RoleItem.USER);
            if (!this.Roles.Contains(r))
                this.Roles.Add(r);
        }
        public string Email
        {
            get; set;
        }
        public string Password
        {
            get; set;
        }
        private List<RoleItem> Roles;
        public void addRole(RoleItem r)
        {
            Roles.Add(r);
        }
        public void remove(RoleItem r)
        {
            if (Roles.Contains(r))
            {
                Roles.Remove(r);
            }
        }

    }
    /// <summary>
    /// This class represents a conversation group
    /// </summary>
    public class Group : TimeStampableItem
    {
        public string Label
        {
            get; set;
        }
        private User GroupCreator { get; set;
        }
        private List<User> members;
        public Group(string name, User admin):base()
        {
            this.Label = name;
            this.members = new List<User>();
            this.GroupCreator = admin;
            this.GroupCreator.addRole(RoleItem.GROUP_ADMIN);

        }
        public void addMember(User user)
        {
            members.Add(user);
        }
        public void reMember(User user)
        {
            if (members.Contains(user))
            {
                members.Remove(user);
            }
        }
    }

    public class Message :TimeStampableItem
    {
        public MessageStatus Status { get; set; }
        public User Source { get; set; }
        public User Destination { get; set; }
        public String Content
        {
            get; set;
        }
        public Message(string content, MessageStatus st, User src, User dst) : base()
        {
            this.Content = content;
            this.Status = st;
            this.Source = src;
            this.Destination = dst;
        }
    }

    public class Conversation:TimeStampableItem
    {
        public Group members;
        public List<Message> messages;
    }
}
