﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyrion.Models
{
    public class MusicContext : DatabaseSet
    {
        public MusicContext() : base() { }
        public MusicContext(string connectionString) : base(connectionString) { }
    }
}
