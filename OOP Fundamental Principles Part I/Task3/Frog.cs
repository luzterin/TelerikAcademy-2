﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task3
{
    class Frog : Animal, ISound
    {
        public Frog(int age, string name, char sex)
            : base(age, name, sex)
        {
        }
        public void ProduceSound()
        {
            Console.WriteLine(this.Name + " says qwak.");
        }
    }
}
