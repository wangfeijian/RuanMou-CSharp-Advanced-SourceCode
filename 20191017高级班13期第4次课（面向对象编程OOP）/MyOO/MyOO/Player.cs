﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOO
{
    public class Player
    {
        public int Id { get; set; }

        public string Name { get; set; }


        public void Play(Phone phone)
        {


            phone.Start(new Game());
        }
    }
}
