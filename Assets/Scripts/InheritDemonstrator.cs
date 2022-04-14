using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InheritDemonstrator : OOPDemonstrator
{
    private GameObject ChildDemonstrator;
    public GameObject ChildPrefab;
  
    public ParticleSystem ExplosionParticle;

    protected override void DemonstratePillarBehaviour()
    {
       
       
       if(!ChildDemonstrator)
        {
            Instantiate(ExplosionParticle, transform.position, ExplosionParticle.transform.rotation);
            gameObject.SetActive(false);
            SpawnChildDemonstrator();
        }
    }

    protected override string PopulateExplanationText()
    {
        string ExplanationText = "This is the inheritance demonstrator class. This sphere has inherited the variables and methods from the base class and adapted them to demonstrate its own behaviour; spawning a member of the base class.";
        return ExplanationText;
    }


    private void SpawnChildDemonstrator()
    {       
        ChildDemonstrator=Instantiate(ChildPrefab);
    }
    public void OnDestroy()
    {
        Destroy(ChildDemonstrator);
    }
}
