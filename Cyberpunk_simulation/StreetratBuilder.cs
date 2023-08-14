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
            this.Reset();
        }

        public void Reset()
        {
            this.character = new Character();
        }

        public Character GetCharacter()
        {
            Character result = this.character;

            this.Reset();

            return result;
        }

        public void SetName()
        {
            this.character.Name = Name.UserInputNameSetup();
        }

        public void SetName(string name)
        {
            this.character.Name = name;
        }
        public void PickRole()
        {
            this.character.Role = Role.UserInputRoleSetup();
        }

        public void PickRole(CharacterRole role)
        {
            this.character.Role = role;
        }

        
    }
}
