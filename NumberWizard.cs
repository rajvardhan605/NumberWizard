using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int min=1, max=1000, guess=500;
    // Start is called before the first frame update
    void Start()
    {
           StartGame();     
    }
    void StartGame()
    {
        min=1; max=1000; guess=500;
        Debug.Log(":::::Welcome To Number Wizard:::::");
        Debug.Log("Pick a number in your mind don't let me know");
        Debug.Log("Lowest number to choose is "+min);
        Debug.Log("Highest number to choose is "+max);
        Debug.Log("Is your number higher or lower than "+ guess);
        Debug.Log("Press up :: Higher || Press down :: Lower || Enter :: Correct");
        max=max+1;
    }
    // Update is called once per frame
    void Update()
    {
        //Detect when the up arrow key is pressed down
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min=guess;
            NextGuess();
        }

        //Detect when the down arrow key is pressed down
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max=guess;
            NextGuess();
        }
        //Detect when the return key is pressed down
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Hurray! I gussed correct...");
            StartGame();
        }
    }
    void NextGuess()
    {
        guess=(min+max)/2;
        Debug.Log("Is your number higher or lower than "+ guess);
    }
}
