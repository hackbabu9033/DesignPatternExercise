using BuildPattern.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuildPattern
{
    public class CharacterBuild : ICharacterBuilder
    {
        private Character _character { get; set; }

        public CharacterBuild()
        {
            _character = new Character();
        }
        public ICharacterBuilder SetCharacterExtraSkill(Skill skill)
        {
            _character.ExtraSkill = skill;
            return this;
        }

        public ICharacterBuilder SetCharacterName(string characterName)
        {
            _character.Name = characterName;
            return this;
        }

        public ICharacterBuilder SetCharacterPassive1(Passive passive)
        {
            _character.Passive1 = passive;
            return this;
        }

        public ICharacterBuilder SetCharacterPassive2(Passive passive)
        {
            _character.Passive2 = passive;
            return this;
        }


        public ICharacterBuilder SetCharacterSkill1(Skill skill)
        {
            _character.Skill1 = skill;
            return this;
        }

        public ICharacterBuilder SetCharacterSkill2(Skill skill)
        {
            _character.Skill2 = skill;
            return this;
        }

        public ICharacterBuilder SetCharacterTalentUpgrade(TalentUpgrade talentUpgrade)
        {
            _character.TalentUpgradeRequiredContents = talentUpgrade;
            return this;
        }

        public ICharacterBuilder SetElement(Element element)
        {
            _character.Element = element;
            return this;
        }

        public ICharacterBuilder SetCharacterIsLimitTimeCharater(bool isLimitTimeCharater)
        {
            _character.IsLimitTimeCharater = isLimitTimeCharater;
            return this;
        }

        public Character Build()
        {
            return _character;
        }

       
    }
}
