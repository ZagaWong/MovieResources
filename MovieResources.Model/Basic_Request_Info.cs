﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieResources.Model
{
    public class Basic_Request_Info
    {
        public Guid Id { get; set; }
        public Guid User { get; set; }
        public Guid Movie { get; set; }
        public string Note { get; set; }
        public string State { get; set; }
        public DateTime Time { get; set; }
    }
}
