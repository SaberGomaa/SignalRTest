using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using SignalRTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace SignalRTest.HubFolder
{
    [HubName("user")]
    public class UserHub : Hub
    {
        ChatDataBaseContext dbContext;

        public UserHub()
        {
            dbContext = new ChatDataBaseContext();
        }
        public void create(User user)
        {
            dbContext.Users.Add(user);
            dbContext.SaveChanges();

            Clients.All.newUser(user);
        }
    }
}