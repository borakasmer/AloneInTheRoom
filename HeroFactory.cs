using AloneInTheRoom.Positions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AloneInTheRoom
{
    public class HeroFactory
    {
        private int x;
        private int y;
        private Point roomSize;
        private PositonEnum positon;
        public HeroFactory() { }

        public IHero CreateRobot(Point _roomSize, int _x, int _y, PositonEnum _positon)
        {
            x = _x;
            y = _y;
            positon = _positon;
            roomSize = _roomSize;
            IHero hero = new Hero(x, y, roomSize);
            hero.Positon = PostionFactory.GeneratePositon(hero, positon);
            return hero;
        }
    }
}
