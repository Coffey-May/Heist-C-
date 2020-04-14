using System;
using System.Collections.Generic;
using System.Linq;

namespace HeistV2 {
    public class Bank {
        public int CashOnHand { get; set; }
        public int AlarmScore { get; set; }
        public int VaultScore { get; set; }
        public int SecurityGuardScore { get; set; }
        public bool IsSecure {
            get {
                if (AlarmScore + VaultScore + SecurityGuardScore <= 0) {
                    return false;
                } else {
                    return true;
                }

            }
        }
        public Bank (int cash, int alarm, int vault, int security) {
            CashOnHand = cash;
            AlarmScore = alarm;
            VaultScore = vault;
            SecurityGuardScore = security;

        }
    }
}