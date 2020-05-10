using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vensi
{
    class Player
    {
     
        public string Name { get; set; }
        public GraphicCardSet Cards { get; set; }
        public int CurrentScore { get; set; }
     

        public Player(string name)
        {
            Name = name;
        }

        public Player(string name,GraphicCardSet cards)
        {
            Name = name;
            Cards = cards;
           
        }
       
       
    }
}
