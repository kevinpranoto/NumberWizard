using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour 
{
	int max;
	int min;
	int guess;

	public Text text;

	public int MaxGuessAllowed = 10;
	// Use this for initialization
	void Start () 
	{
		StartGame();
	}
	
	void StartGame()
	{
		max = 1000;
		min = 1;
		max += 1;
		NextGuess();
	}

	// Update is called once per frame
	void Update () 
	{
	}

	public void GuessHigher()
	{
		min = guess;
		NextGuess();
	}

	public void GuessLower()
	{
		max = guess;
		NextGuess();
	}

	void NextGuess()
	{
		guess = Random.Range(min, max);
		text.text = "" + guess;
		MaxGuessAllowed -= 1;
		if(MaxGuessAllowed <= 0)
		{
			SceneManager.LoadScene("Win");
			Debug.Log("calling win screen");
		}
	}
	
}
