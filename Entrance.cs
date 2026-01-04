using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALTTP_Helper_CSharp
{
    public class Entrance
    {
        private string _entrance = null!;
        private string _exit = null!;
        private string _direction = null!;

        public Entrance() 
        {
           
        }
        public Entrance(string entrance, string exit, string direction)
        {
            _entrance = entrance;
            _exit = exit;
            _direction = direction;     //Not sure how this will be used, but will be stored in case
        }
    }
}
