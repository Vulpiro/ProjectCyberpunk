﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberpunk_simulation.Characters
{
    interface ICharacterBuilder
    {
        void SetName();
        void SetName(string name);
        void PickRole();
        void PickRole(CharacterRole role);
        void RollSTATS();
    }
}
