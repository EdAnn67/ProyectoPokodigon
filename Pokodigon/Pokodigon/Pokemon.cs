using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokodigon
{
    class Pokemon
    {
        public string name;
        public string Name
        {
            get { return name; }
            set {name = value; }
        }

        public string type;
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public string attack1n;
        public string Attack1N
        {
            get { return attack1n; }
            set { attack1n = value; }
        }
        public int attack1;
        public int Attack1
        {
            get { return attack1; }
            set { attack1 = value; }
        }
        public string attack2n;
        public string Attack2N
        {
            get { return attack2n; }
            set { attack2n = value; }
        }
        public int attack2;
        public int Attack2
        {
            get { return attack2; }
            set { attack2 = value; }
        }
        public int hp;
        public int HP
        {
            get { return hp; }
            set { hp = value; }
        }


        
    }
}
