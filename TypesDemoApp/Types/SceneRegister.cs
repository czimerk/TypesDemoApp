using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeDemoApp.Types
{
    internal class SceneRegister
    {
        public List<Scene> Scenes { get; set; } = new List<Scene>();
        
        public static void PrintCharacter(WitcherCharacter character)
        {
            if (character != null)
            {
                Console.WriteLine(character.Name);
            }
            return;
        }

    }

    internal class Scene
    {
        public int SceneId { get; set; }
        public string Script { get; set; }
    }
}
