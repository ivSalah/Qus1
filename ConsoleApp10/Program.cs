using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salah.H.W
{
class UserAccount
        {
            public string Email;
            public string Username;
            public string Password;
            public UserAccount(string email, string username, string
           password)

            {
                Email = email;
                Username = username;
                Password = password; }           
            public UserAccount(UserAccount existingAccount)
            {
                Email = existingAccount.Email;
                Username = existingAccount.Username;
                Password = existingAccount.Password;}
            public void DisplayAccount()
            {
                Console.WriteLine(Email);
                Console.WriteLine(Username);
                Console.WriteLine(Password);  }
        }
        class Program
        {
            static void Main(string[] args)
            {
                ArrayList a = new ArrayList();
                UserAccount originalAccount1 = new UserAccount
               ("user1@example.com", "user1", "pass1");
                UserAccount originalAccount2 = new UserAccount
           ("user2@example.com", "user2", "pass2");
                UserAccount originalAccount3 = new UserAccount
               ("user3@example.com", "user3", "pass3");
                UserAccount mt = new UserAccount(originalAccount1);
                a.Add(mt);
                mt = new UserAccount(originalAccount2);
                a.Add(mt);
                mt = new UserAccount(originalAccount3);
                a.Add(mt);               
                Console.WriteLine("Stored User Accounts:");
                for (int i = 0; i < a.Count; i++)
                {
                    UserAccount account = (UserAccount)a[i];
                    Console.WriteLine(account.Email);
                    Console.WriteLine(account.Username);
                    Console.WriteLine(account.Password);
                    Console.WriteLine("-------------------------");
                }
                Console.WriteLine("you have 3 trys");
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("enter the email ");
                    string e = Console.ReadLine();
                    Console.WriteLine("enter the password");
                    string p = Console.ReadLine();
                    bool n = false;
                    for (int j = 0; j < a.Count; j++)
                    {
                        UserAccount c = (UserAccount)a[j];
                        if (c.Email == e && c.Password == p)
                        {
                            n = true;
                            Console.WriteLine("correct");
                            break;
                        }
                    }
                    if (!n)
                        Console.WriteLine("wrong !!");
                    else
                       break;
                }     Console.ReadLine();
            }
    }
}
