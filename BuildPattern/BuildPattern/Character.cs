using BuildPattern.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuildPattern
{
    public class Character
    {
        //// if we use ctor,then the parameter will become very long
        //public Character(string Name,
        //    Element element,
        //    Skill skill1, 
        //    Skill skill2, 
        //    Passive passive1, 
        //    Passive passive2, 
        //    TalentUpgrade talentUpgrade, 
        //    Skill ExtraSkill = null)
        //{
            
        //}

        public string Name { get; set; }
        public Element Element { get; set; }
        public Skill Skill1 { get; set; }
        public Skill Skill2 { get; set; }
        public Passive Passive1 { get; set; }
        public Passive Passive2 { get; set; }
        /// <summary>
        /// only-some character would have extra skill
        /// </summary>
        public Skill ExtraSkill { get; set; }
        public TalentUpgrade TalentUpgradeRequiredContents { get; set; }
        public bool IsLimitTimeCharater { get; set; }
    }

    public class TalentUpgrade
    {
        public int RequireMora { get; set; }
        public Dictionary<int,CommonMaterial> RequiredMaterials { get; set; }
    }
}
