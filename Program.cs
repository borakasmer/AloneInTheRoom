// See https://aka.ms/new-console-template for more information
using AloneInTheRoom;
using AloneInTheRoom.Positions;
using System.Drawing;

/*Point roomSize = new(5, 5);
(int x, int y, Point roomSize) heroProperties = (1, 2, roomSize);
var hero = new Hero(heroProperties.x, heroProperties.y, heroProperties.roomSize);
hero.Positon = PostionFactory.CreatePositon(PositonEnum.N, hero);
*/
HeroFactory hf = new();
(int width, int height) roomSize = (5, 5);
(int x, int y, string Positon) robotProperties = (1, 2, "N");
IHero hero = hf.CreateRobot(new(roomSize.width, roomSize.height), robotProperties.x, robotProperties.y, robotProperties.Positon.GetPositonEnum());


string moveList = "LMLMLMLMM";
hero.MoveHero(moveList);
Console.WriteLine($"{hero.X},{hero.Y},{hero.Positon.CurrentPositon()}");