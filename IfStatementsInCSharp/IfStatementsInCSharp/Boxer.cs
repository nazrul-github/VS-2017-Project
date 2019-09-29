using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Boxer
    {
    public string Name { get; set; }

    private int punchSpeed;

    public Boxer(string nameValue, int punchSpeedValue) {
        Name = nameValue;
        PunchSpeed = punchSpeedValue;
    }
    public int PunchSpeed { get { return punchSpeed; } set { if (value > 0) { if (value < 500) { punchSpeed = value; } } } }
    public string PunchSpeedEvaluation { get { string evaluationString = String.Empty; if (PunchSpeed >= 450) { evaluationString = "Great Speed!"; } else if (PunchSpeed >= 400)
            { evaluationString = "Good Speed!"; } else if (PunchSpeed >= 300) { evaluationString = "Not Bad!!"; } else { evaluationString = "Bad!!!"; } return evaluationString;
        } } 
}

