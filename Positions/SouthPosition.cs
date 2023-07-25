using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AloneInTheRoom.Positions
{
    public class SouthPositon : BasePositon, IPositon
    {
        public SouthPositon(IHero hero) : base(hero) { }
        public string CurrentPositon() { return this.GetCurrentPosition().ToString(); }
        public IHero Hero { get { return hero; } set { hero = value; } }
        public void Left()
        {
            base.hero.Positon = PostionFactory.GeneratePositon(hero, PositonEnum.E);
        }

        public void Move()
        {
            base.hero.Y = hero.Y - 1 >= 0 ? hero.Y - 1 : hero.Y;
        }

        public void Right()
        {
            base.hero.Positon = PostionFactory.GeneratePositon(hero, PositonEnum.W);
        }
    }
}
