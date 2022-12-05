using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogActivator : MonoBehaviour
{
    public string[] lines;

    private bool canActive;

    public bool isPerson = true;

    public bool shouldActivateQuest;
    public string questToMark;
    public bool markComplete;

    // Start is called before the first frame update
    void Start()
    {
        
    } 

    // Update is called once per frame
    void Update()
    {
        if(canActive && Input.GetButtonDown("Fire1") && !DialogManager.instance.dialogBox.activeInHierarchy)
        {
            DialogManager.instance.ShowDialog(lines, isPerson);
            DialogManager.instance.ShouldActiveQuestAtEnd(questToMark, markComplete);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        { 
            canActive = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            canActive = false;
        }
    }
}
