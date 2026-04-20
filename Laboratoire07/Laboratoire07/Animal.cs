using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice07
{
    internal abstract class Animal//il faut aussi que je sache que la classe est abstract
    {
        string dateNaissance;

        public Animal() { }

        public int getAge()
        {
            return 0;
        }

        public abstract void PousserCri(); //faut que tu le comprenne par toi mm que c'est abstract
 
    }
}
