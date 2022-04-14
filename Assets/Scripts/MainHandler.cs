using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor;

public class MainHandler : MonoBehaviour
{
    public GameObject[] PillarDemoObjects;
    public GameObject CurrentDemoObject;
    public Button ExplanationTextBox;
    public OOPDemonstrator m_Demonstrator;
    // Start is called before the first frame update
    void Start()
    {
        
        RunDemo("base");
    }

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene(0);
    }


    public void RunDemo(string pillarName)
    {
        Destroy(CurrentDemoObject);
        for (int i = 0; i < PillarDemoObjects.Length; i++)
        {
            if (PillarDemoObjects[i].gameObject.CompareTag(pillarName))
            {
                CurrentDemoObject = Instantiate(PillarDemoObjects[i]);
                ExplanationTextBox.GetComponentInChildren<Text>().text = CurrentDemoObject.GetComponent<OOPDemonstrator>().PillarExplanationText;
            }
        }
        
    }
    
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
