using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    [SerializeField] Text textCompoent; //now its available in our inspector in Unity
    [SerializeField] State startingState;

    State state; // track our state of the game and current state
    // Start is called before the first frame update
    void Start()
    {
        state = startingState; //which is our scriptable object
        textCompoent.text = state.GetStateStory();
    }

    // Update is called once per frame
    void Update()
    {
        ManageState();

    }

    private void ManageState()
    {
        var nextStates = state.GetNextStates();
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            state = nextStates[0];
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            state = nextStates[1];
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            state = nextStates[2];
        }
        textCompoent.text = state.GetStateStory();
    }
}
