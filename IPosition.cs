using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AloneInTheRoom
{
    public interface IPositon { 
        public void Move(); 
        public void Left(); 
        public void Right(); 
        public string CurrentPositon(); 
        public IHero Hero { get; set; } 
    }
}
