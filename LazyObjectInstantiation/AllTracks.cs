﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyObjectInstantiation
{
    internal class AllTracks
    {
        private Song[] _allSongs = new Song[10000];

        public AllTracks()
        {
            Console.WriteLine("Filling up the songs!");
        }
    }
}
