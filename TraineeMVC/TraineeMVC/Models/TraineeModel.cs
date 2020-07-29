using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TraineeMVC.Models
{
    public class TraineeModel
    {
        public int TraineeId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime DateOfJoining { get; set; }
    }
}