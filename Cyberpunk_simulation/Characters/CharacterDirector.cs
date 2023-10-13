using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberpunk_simulation.Characters
{
    class CharacterDirector
    {
        private ICharacterBuilder _builder;

        public ICharacterBuilder Builder
        {
            set { _builder = value; }
        }

        public void BuildStreetratCharacter()
        {
            _builder.SetName();
            _builder.PickRole();
            _builder.RollSTATS();
        }

        public void BuildStreetratCharacter(string name, CharacterRole role)
        {
            _builder.SetName(name);
            _builder.PickRole(role);
            _builder.RollSTATS();
        }
    }
}
