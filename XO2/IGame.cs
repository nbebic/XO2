using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XO2
{
    interface IGame
    {
        int BlueModif{get;set;}
        int RedModif{get;set;}
        void Load(string[] GameData, Form1 par);
    }
}
