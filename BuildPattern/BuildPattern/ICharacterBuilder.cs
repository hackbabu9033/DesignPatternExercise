using BuildPattern.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuildPattern
{
    public interface ICharacterBuilder
    {
        ICharacterBuilder SetCharacterName(string characterName);
        ICharacterBuilder SetElement(Element element);

        ICharacterBuilder SetCharacterSkill1(Skill skill);
        ICharacterBuilder SetCharacterSkill2(Skill skill);
        ICharacterBuilder SetCharacterExtraSkill(Skill skill);
        ICharacterBuilder SetCharacterPassive1(Passive passive);
        ICharacterBuilder SetCharacterPassive2(Passive passive);

        ICharacterBuilder SetCharacterTalentUpgrade(TalentUpgrade talentUpgrade);
        ICharacterBuilder SetCharacterIsLimitTimeCharater(bool isLimitTimeCharater);
        Character Build();
    }
}
