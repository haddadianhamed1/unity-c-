using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")] //adds State to our menu in unity

public class State : ScriptableObject
{
    [TextArea(10,14)][SerializeField] string storyText;
    //TextArea 10 minimum size in our spectare second number 14 is the amount of lines before we scroll
    [SerializeField] State[] nextStates;
    public string GetStateStory()
    {
        return storyText;
    }

    public State[] GetNextStates()
    {
        return nextStates;
    }
}


