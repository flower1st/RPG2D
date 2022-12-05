using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestObjectActivator : MonoBehaviour
{
    public GameObject objectToActive;

    public string questToCheck;

    public bool activeIfComplete;

    private bool initialCheckDone;
    // Start is called before the first frame update
    void Start()
    {
        if (!initialCheckDone)
        {
            initialCheckDone = true;
            CheckCompletion();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
  
    public void CheckCompletion()
    {
        if (QuestManager.instance.CheckIfComplete(questToCheck))
        {
            objectToActive.SetActive(activeIfComplete);
        }
    }
}
