using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeDemoApp.Types
{
    internal class Cast
    {
        internal WitcherCharacterPosition CharacterValue { get; set; }
        public Cast(string mainCharacter)
        {
            CharacterValue = new WitcherCharacterPosition(1, 0, 0);
        }
    }
}
