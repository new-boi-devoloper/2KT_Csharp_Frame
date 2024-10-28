using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iks_Dmitry_CatFramework
{
    public abstract class Cat
    {
        public virtual int Fluffiness { get; private set; }

        public virtual string FluffinessCheck()
        {
            return "Fluffiness";
        }

        public override string ToString()
        {
            return $"a cat with _fluff: { Fluffiness}";
        }
    }
}
