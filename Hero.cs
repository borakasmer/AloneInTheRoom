using AloneInTheRoom.Positions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AloneInTheRoom
{
    public class Hero : IHero
    {
        private int x;
        private int y;
        private Point roomSize;
        private IPositon positon;

        public Hero(int _x, int _y, Point _roomSize)
        {
            X = _x;
            Y = _y;
            roomSize = _roomSize;
        }
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public IPositon Positon { get => positon; set => positon = value; }
        public Point RoomSize { get => roomSize; set => roomSize = value; }
        public void MoveHero(string moveList)
        {
            moveList.ToList().ForEach(p =>
            {
                switch (p.GetMoveEnum())
                {
                    case MoveEnum.M:
                        Positon.Move();
                        break;
                    case MoveEnum.R:
                        Positon.Right();
                        break;
                    case MoveEnum.L:
                        Positon.Left();
                        break;
                    default:
                        throw new ArgumentException("Invalid enum value for command", p.ToString());
                        break;
                };
            });
        }
    }
}
