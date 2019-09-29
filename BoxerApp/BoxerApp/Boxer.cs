using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxerApp
{
    class Boxer
    {
        private String name;
        private int punchPower;
        private decimal kickPower;
        private decimal rightHookPower;
        private decimal leftHookPower;

        public String Name { get { return name; }
            set { name = value; } }
        public int PunchPower { get { return punchPower; } private set{
            if (value > 0) { punchPower = value; } } }
        public decimal KickPower { get { return kickPower; }private set { if (value > 0) { kickPower = value; } } }
        public decimal RightHookPower { get { return rightHookPower; }private set { if (value > 0) { rightHookPower = value; } } }
        public decimal LeftHookPower { get { return leftHookPower; } private set { if (value > 0) { leftHookPower = value; } } }

    public Boxer(string nameValue, int punchPowerValue, decimal kickPowerValue, decimal rightHookPowerValue, decimal leftHookPowerValue) { Name = nameValue;
        PunchPower = punchPowerValue; RightHookPower = rightHookPowerValue; LeftHookPower = leftHookPowerValue; KickPower = kickPowerValue;
    }
        public int IncreasePunchPower(int incrsPunchPower) { if (incrsPunchPower>10) { PunchPower = PunchPower + incrsPunchPower; } return PunchPower; }
        public decimal IncreaseKickPower(decimal incrsKickPower) { if (incrsKickPower > 10) { KickPower = KickPower + incrsKickPower; } return KickPower; }
        public decimal IncreaseRightHookPower(decimal incrsRightHookPower) { if (incrsRightHookPower > 10) { RightHookPower = RightHookPower + incrsRightHookPower;} return RightHookPower; }
        public decimal IncreaseLeftHookPpower(decimal incrsLeftHookPower) { if (incrsLeftHookPower > 10) { LeftHookPower = LeftHookPower + incrsLeftHookPower; } return LeftHookPower; }


    }
}

