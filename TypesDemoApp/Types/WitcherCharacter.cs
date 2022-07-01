using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeDemoApp.Types
{
    internal class WitcherCharacter
    {
        public WitcherCharacter(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException(nameof(name));
            }
            Name = name;
        }
        public int CharacterId { get; }
        public string Name { get; set; }

        private string _publicId;
        public string PublicId
        {
            get
            {
                if (_publicId == null)
                {
                    _publicId = PublicIdGenerator.Generate(Name);
                }
                return _publicId;
            }
        }
        private class PublicIdGenerator
        {
            private static int CharacterCount = 0;
            internal static string Generate(string name)
            {
                if (string.IsNullOrEmpty(name))
                {
                    throw new ArgumentException($"'{nameof(name)}' " +
                        $"cannot be null or empty.", nameof(name));
                }

                return name + CharacterCount++;
            }
        }
    }
}
