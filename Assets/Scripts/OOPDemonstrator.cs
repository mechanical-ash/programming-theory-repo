using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OOPDemonstrator : MonoBehaviour
{
    protected string ClassName;
    // Start is called before the first frame update
    void Start()
    {
        ClassName = "base";
        Greet();   
    }
    
    protected void Greet()
    {
        Debug.Log("This is the "+ClassName+" class");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
