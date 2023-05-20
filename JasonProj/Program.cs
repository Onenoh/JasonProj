using System;
using System.Collections.Generic;

namespace JasonProj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>();
            User user = new User();
            user.Name = "Samuel";
            user.Email = "test@gmail.com";
            user.Password = "Bullseye12345#";
            user.PhoneNumbers.Add("018928338747474");
            user.PhoneNumbers.Add("3871038383838338");
            user.Addresses.Add(new Address()
            {
                MainAddress = "3 -6 bla bla bla ",
                City = "Lagos",
                State = "Lagos",
                LGA = "Ikeja",
                UserId = user.Id,
            });
            user.Addresses.Add(new Address()
            {
                MainAddress = "3 -10 bla bla bla ",
                City = "Lagos",
                State = "Lagos",
                LGA = "Ikeja",
                UserId = user.Id
            });
            User user1 = new User();
            user1.Name = "Ayodele";
            user1.Email = "emmanuel.ogidan@sbc.com";
            user1.Password = "Bullseye12345#";
            user1.PhoneNumbers.Add("018928338747474");
            user1.PhoneNumbers.Add("3871038383838338");
            user1.Addresses.Add(new Address()
            {
                MainAddress = "3 -6 bla bla bla ",
                City = "Lagos",
                State = "Lagos",
                LGA = "Ikeja",
                UserId = user1.Id,
            });
            user1.Addresses.Add(new Address()
            {
                MainAddress = "3 -10 bla bla bla ",
                City = "Lagos",
                State = "Lagos",
                LGA = "Ikeja",
                UserId = user1.Id
            });

            users.Add(user1);
            users.Add(user);

            //User user = new User()
            //{
            //    Name = "Test",
            //    Username = "Test@",
            //    Email = "test@gmail.com",
            //    Password = "Bullseye12345#",
            //    PhoneNumbers = new List<string>()
            //    {
            //       "0188234557622",
            //       "01923458847474"
            //    },
            //};
            //List<Address> addresses = new List<Address> {
            //        new Address()
            //        {
            //            MainAddress = "3 -6 bla bla bla ",
            //            City =  "Lagos",
            //            State = "Lagos",
            //            LGA = "Ikeja",
            //            UserId = user.Id,
            //        },
            //        new Address()
            //        {
            //            MainAddress = "3 -10 bla bla bla ",
            //            City =  "Lagos",
            //            State = "Lagos",
            //            LGA = "Ikeja",
            //            UserId = user.Id
            //        }
            //    };
            //user.Addresses = addresses;
            WriteToJson writeToJson = new WriteToJson();
            writeToJson.WriteToJsons(users);
        
        }
    }
}

