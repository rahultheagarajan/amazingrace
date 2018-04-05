using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AmazingRace.Models
{
    public class UserActiviation
    {
        public int userId { get; set; }
        public string ActivationCode { get; set; }
    }
}