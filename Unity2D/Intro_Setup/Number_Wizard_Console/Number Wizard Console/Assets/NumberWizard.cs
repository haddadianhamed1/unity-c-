using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max ;
    int min ;
    int guess;


    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }


    void StartGame()
    {
        max = 1000;
        min = 0;
        guess = 500;
        Debug.Log("Welcome to number Wizard");
        Debug.Log("Pick a Number, don't tell me!");
        Debug.Log("Highest Number is: " + max);
        Debug.Log("Lowest Number is: " + min);

        Debug.Log("tell me if your number is higher or lower than my guess: " + guess);
        Debug.Log("push Up = higher, push down=lower, Push ENter= correct");
        max = max + 1;
        min = min - 1;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("yes I got it right!!!");
            StartGame();
        }

    }


    void NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("is it higher or lower than " + guess);
    }
}
