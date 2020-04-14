using System;
using System.Collections.Generic;
using System.Linq;
namespace HeistV2 {
    public interface IRobber {
        string Name { get; set; }
        int SkillLevel { get; set; }
        int PercentageCut { get; set; }
        void PerformSkill (Bank bank);

    }
}