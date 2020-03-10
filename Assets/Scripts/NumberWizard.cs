using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] bool useRandom;
    int guess;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame() {
        updateGuess();
    }

    public void onPressHigher() {
        min = Math.Min(guess+1, max);
        updateGuess();
    }

    public void onPressLower() {
        max = Math.Max(guess-1, min);
        updateGuess();
    }

    private void updateGuess() {
        if (useRandom) {
            guess = UnityEngine.Random.Range(min, max + 1);
        } else {
            guess = (max + min)/2;
        }
        displayGuess();
    }

    private void displayGuess()
    {
        var guessDisplay = GameObject.Find("Guess Background/Guess Text");
        guessDisplay.GetComponent<TextMeshProUGUI>().text = guess.ToString();
        return;
    }
}
