﻿using System;
using System.Collections.Generic;
using System.Text;

namespace IsaLifeUpdated
{
    public class User
    {
        public string Name { get; set; }
        public string Designation { get; set; }
        public string ImageSRC { get; set; }

        public User(string name, string designation, string src)
        {
            Name = name;
            Designation = designation;
            ImageSRC = src;
        }
    }
}
