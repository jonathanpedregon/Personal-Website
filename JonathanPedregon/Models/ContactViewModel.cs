using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace JonathanPedregon.Models
{
    public class ContactViewModel
    {
        public string EmailAddress => "jonathanpedregon@gmail.com";
        public string Location => "Sandy, UT";
        public string Name => "Jonathan Pedregon";
        public string PhoneNumber => "(915)-252-8465";

        public ContactViewModel()
        {
        }

        private void ParseConfig()
        {
            //using (var reader = new StreamReader(Server.MapPath("~/Configs/ContactConfig.json")))
            //{
            var json = File.ReadAllText("~/Configs/ContactConfig.json");
            JsonConvert.DeserializeObject<ContactViewModel>(json);
            //}
        }
    }
}