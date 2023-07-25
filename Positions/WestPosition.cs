using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AloneInTheRoom.Positions
{
    public class WestPositon : BasePositon, IPositon
    {
        public WestPositon(IHero hero) : base(hero) { }
        public string CurrentPositon()
        {
            return this.GetCurrentPosition().ToString();
        }
        public IHero Hero
        {
            get { return hero; }
            set { hero = value; }
        }
        public void Left()
        {
            base.hero.Positon = PostionFactory.GeneratePositon(hero, PositonEnum.S);
        }

        public void Move()
        {
            base.hero.X = hero.X - 1 >= 0 ? hero.X - 1 : hero.X;
        }

        public void Right()
        {
            base.hero.Positon = PostionFactory.GeneratePositon(hero, PositonEnum.N);
        }
    }
}
