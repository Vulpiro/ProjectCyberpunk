using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberpunk_simulation
{
    class StreetratBuilder : ICharacterBuilder
    {
        private Character character = new Character();

        public StreetratBuilder()
        {
            Reset();
        }

        public void Reset()
        {
            character = new Character();
        }

        public Character GetCharacter()
        {
            Character result = this.character;

            Reset();

            return result;
        }

        public void SetName()
        {
            character.Name = Name.UserInputNameSetup();
        }

        public void SetName(string name)
        {
            character.Name = name;
        }
        public void PickRole()
        {
            character.Role = Role.UserInputRoleSetup();
        }

        public void PickRole(CharacterRole role)
        {
            character.Role = role;
        }

        public void RollSTATS()
        {
            GenerateSTATS.GenerateStreetratSTATS(character);
        }
    }
}
