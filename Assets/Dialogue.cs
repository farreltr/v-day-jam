using UnityEngine;
using System.Collections;
using PixelCrushers.DialogueSystem;

public class Dialogue : MonoBehaviour {

    Subtitle sub; 
	// Use this for initialization
	void Start () {
        
	}


     public void DialogueRun(string conversation)
    {
        
        DialogueManager.StartConversation(conversation);
       if  ( Field.LookupBool(sub.dialogueEntry.fields,"special"))
       {

       }
        
    }

	// Update is called once per frame
	void Update () {
	
	}
}
