using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PolyDemonstrator : OOPDemonstrator
{



    protected override void DemonstratePillarBehaviour()
    {
        Move();
    }
    protected override string PopulateExplanationText()
    {
        string ExplanationText = "This is the polymorphism demonstrator class. The base 'Move' method has been overriden to allow for movement in the vertical plane.";
        return ExplanationText;
    }


    protected override void Move()
    {
        if (reachedGoal)
        {
            goal = new Vector3(Random.Range(-5, 5), Random.Range(0,5), Random.Range(-5, 5));
            reachedGoal = false;
        }
        if (!reachedGoal)
        {
            transform.position = Vector3.MoveTowards(transform.position, goal, 3.0f * Time.deltaTime);
            if (transform.position == goal)
            {
                reachedGoal = true;
            }
        }
    }
}
