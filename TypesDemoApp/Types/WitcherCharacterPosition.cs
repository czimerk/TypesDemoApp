using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeDemoApp.Types
{
    internal struct WitcherCharacterPosition
    {
        public WitcherCharacterPosition(int characterId, int x, int y)
        {
            CharacterId = characterId;
            Position = new Point(x, y);
        }
        public int CharacterId { get; }
        public Point Position { get; set; }
    }
}
