using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OOPDemonstrator : MonoBehaviour
{
    public string PillarName;
    public string PillarExplanationText;
    protected Vector3 goal;
    protected bool reachedGoal;
    protected Rigidbody demonstratorRb;

    // Start is called before the first frame update
    void Awake()
    {
        PillarName = gameObject.tag;
        PillarExplanationText = PopulateExplanationText();
        Greet();
        demonstratorRb = GetComponent<Rigidbody>();
        reachedGoal = true;
    }
    
    protected void Greet()
    {
       // Debug.Log("This is the "+PillarName+" pillar");

    }
    protected virtual string PopulateExplanationText()
    {
        string ExplanationText = "This is the base demonstrator class. By default, the sphere will move around random points on the ground.";
        return ExplanationText;
    }

    // Update is called once per frame
    void Update()
    {        
        DemonstratePillarBehaviour();
    }
    protected virtual void DemonstratePillarBehaviour()
    {
        Move();
    }
    protected virtual void Move()
    {
        if(reachedGoal)
        {
            goal = new Vector3(Random.Range(-5,5), 0, Random.Range(-5,5));
            reachedGoal = false;
        }
        if (!reachedGoal)
        {
            transform.position = Vector3.MoveTowards(transform.position, goal, 3.0f*Time.deltaTime);
            if (transform.position == goal)
            {
                reachedGoal = true;
            }
        }
        
    }
}
