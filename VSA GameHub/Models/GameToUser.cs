using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using VSA_GameHub.Models;

namespace VSA_GameHub.Models
{
    public class GameToUser
    {
        [Key]
        public int Id { get; set; }
        public string GameName { get; set; }
        public string UserName { get; set; }
        public int GameId { get; set; }
        public string UserId { get; set;}
    }
}