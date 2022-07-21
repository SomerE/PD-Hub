using Ink.Runtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroDialogScript : MonoBehaviour
{
    //If seenIntro is false, this needs to start immediately. If true, it only want to start on clicking E within radius of NPC

    public TextAsset inkJSON;
    private Story story;

    void Start()
    {
        story = new Story(inkJSON.text);
        Debug.Log(story.Continue());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
