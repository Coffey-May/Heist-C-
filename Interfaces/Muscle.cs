using System;
using System.Collections.Generic;
using System.Linq;

namespace HeistV2 {
    public class Muscle : IRobber {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }

        public void PerformSkill (Bank bank) {
            var bankAlarmMinusMuscleSkill = bank.AlarmScore - SkillLevel;
            bank.AlarmScore = bankAlarmMinusMuscleSkill;
            Console.WriteLine ($"{Name} is hacking the alarm system. Decreased security {SkillLevel} points ");
            if (bank.AlarmScore <= 0) {
                Console.WriteLine ($"{Name }has disabled the security guard!");
            }
        }

        public Muscle (string name, int skillLevel, int percentageCut) {
            Name = name;
            SkillLevel = skillLevel;
            PercentageCut = percentageCut;

        }
    }
}