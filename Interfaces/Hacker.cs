using System;
using System.Collections.Generic;
using System.Linq;

namespace HeistV2 {
    public class Hacker : IRobber {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }

        public void PerformSkill (Bank bank) {
            var bankAlarmMinusHackerSkill = bank.AlarmScore - SkillLevel;
            bank.AlarmScore = bankAlarmMinusHackerSkill;
            Console.WriteLine ($"{Name} is hacking the alarm system. Decreased security {SkillLevel} points ");
            if (bank.AlarmScore <= 0) {
                Console.WriteLine ($"{Name }has disabled the alarm system!");
            } else {
                Console.WriteLine ($"{Name} got nabbed by the coppers.");
            }
        }
        public Hacker (string name, int skillLevel, int percentageCut) {
            Name = name;
            SkillLevel = skillLevel;
            PercentageCut = percentageCut;

        }
    }
}