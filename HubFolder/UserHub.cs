//using Microsoft.AspNet.SignalR;
//using Microsoft.AspNet.SignalR.Hubs;
//using SignalRTest.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;

//namespace SignalRTest.HubFolder
//{
//    [HubName("user")]
//    public class UserHub : Hub
//    {
//        ChatDataBaseContext dbContext = new ChatDataBaseContext();

//        public async void create(User user)
//        {
//            dbContext.Users.Add(user);
//            dbContext.SaveChanges();

//            Clients.All.newUser(user);
//        }
//    }
//}