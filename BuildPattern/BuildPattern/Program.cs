using System;
using System.Collections.Generic;

namespace BuildPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // 使用build pattern的時機
            // 1. 物件有很多bool property ex: 角色是否為期間限定
            // 2. 物件可很多可選參數 ex:角色有沒有額外技能、有沒有額外被動(假設一般角色只有兩個技能+被動天賦)
            // 3. 或者是針對這個物件可能有不同的建置流程

            // 這個時候就可以使用建造者模式
            // 用一種 configuration 的方式，拆解每個元件建造的過程，避免有拖得很長的建構子，使建構的意圖清晰許多。
            var akaya = new CharacterBuild().SetCharacterName("akaya")
                .SetElement(Enum.Element.Cryo)
                .SetCharacterPassive1(new Passive() { Name = "Amatsumi Kunitsumi Sanctification" })
                .SetCharacterPassive2(new Passive() { Name = "Kanten Senmyou Blessing" })
                .SetCharacterSkill1(new Skill()
                {
                    Name = "Kamisato Art: Hyouka",
                    Detail = "Summons blooming ice to launch " +
                    "nearby opponents, dealing AoE Cryo DMG."
                })
                .SetCharacterSkill2(new Skill()
                {
                    Name = "Kamisato Art: Soumetsu",
                    Detail = "A storm of whirling icy winds that slashes repeatedly at every enemy it touches, dealing Cryo DMG."
                })
                .SetCharacterExtraSkill(new Skill() { Name = "Kamisato Art: Senho" })
                .SetCharacterTalentUpgrade(new TalentUpgrade()
                {
                    RequiredMaterials = new Dictionary<int, CommonMaterial>()
                    {
                        { 12,new CommonMaterial(){ Name="aaa",RareLevel=Enum.MaterialRareLevel.Rare } }
                    }
                })
                .SetCharacterIsLimitTimeCharater(true)
                .Build();
        }

        
    }
}
