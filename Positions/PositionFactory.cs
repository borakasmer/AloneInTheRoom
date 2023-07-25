using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AloneInTheRoom.Positions
{
    public static class PostionFactory { 
        private static Dictionary<string, IPositon> PostionStorage = new Dictionary<string, IPositon>(); 
        public static IPositon GeneratePositon(IHero hero, PositonEnum postionType) 
        { 
            if (PostionStorage.TryGetValue(postionType.ToString(), out var positon)) 
            { 
                positon.Hero = hero; return positon; 
            } 
            else 
            { 
                var newPositon = CreatePositon(postionType, hero); 
                PostionStorage.Add(postionType.ToString(), newPositon); 
                return newPositon; 
            } 
        } 
        public static IPositon CreatePositon(PositonEnum postion, IHero hero) 
        { 
            return postion switch { 
                PositonEnum.W => new WestPositon(hero), 
                PositonEnum.N => new NorthPositon(hero), 
                PositonEnum.E => new EastPositon(hero), 
                PositonEnum.S => new SouthPositon(hero), }; 
        } 
    }
}
