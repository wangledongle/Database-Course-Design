﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    public class CommentPlus
    {
        public int Qusitionid { get; set; }
        public int Userid { get; set; }
        public int CmdUserid { get; set; }
        public int CmtedUserid { get; set; }
        public int Myid { get; set; }
        public string Datetime { get; set; }
    }
}
