using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbstractDemonstrator : OOPDemonstrator
{
 

    protected override void DemonstratePillarBehaviour()
    {
        
    }

    protected override string PopulateExplanationText()
    {
        string ExplanationText = "This is the abstraction demonstrator class. Each sphere is controlled using the overriden method 'DemonstratePillarBehaviour'. This is a high-abstraction method which allows for easy comprehension of its intended purpose.";
        return ExplanationText;
    }


}
