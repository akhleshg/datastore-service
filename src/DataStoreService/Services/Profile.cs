﻿using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;
using Newtonsoft.Json.Linq;

namespace DataStoreService.Services
{
    public struct Profile
    {
        public string Id { get; set; }
        public string Key { get; set; }
        public string Data { get; set; }
    }
}
