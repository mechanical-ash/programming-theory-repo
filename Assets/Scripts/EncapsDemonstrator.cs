using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EncapsDemonstrator : OOPDemonstrator
{


    protected override void DemonstratePillarBehaviour()
    {

    }
    protected override string PopulateExplanationText()
    {
        string ExplanationText = "This is the encapsulation demonstrator class. Variables and methods across the demonstrator classes have had their access modifiers altered based on the needs of the application. This promotes security and efficiency.";
        return ExplanationText;
    }

}
