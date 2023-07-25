using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AloneInTheRoom.Positions
{
    public class BasePositon { 
        public IHero hero; 
        public BasePositon(IHero _hero) { 
            hero = _hero; 
        } 
        public PositonEnum GetCurrentPosition() 
        { 
            return hero.Positon switch { 
                WestPositon => PositonEnum.W, 
                NorthPositon => PositonEnum.N, 
                EastPositon => PositonEnum.E, 
                SouthPositon => PositonEnum.S, }; 
        } 
    }
}
