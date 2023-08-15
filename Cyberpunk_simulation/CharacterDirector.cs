﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberpunk_simulation
{
    class CharacterDirector
    {
        private ICharacterBuilder _builder;

        public ICharacterBuilder Builder
        {
            set { _builder = value; }
        }

        public void BuildStreetratUserInputCharacter()
        {
            _builder.SetName();
            _builder.PickRole();
            _builder.RollSTATS();
        }
    }
}
