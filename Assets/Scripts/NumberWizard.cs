using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {
		int max ;
		int min ;
		int guess;

	// Use this for initialization

	void Start () {
		
		StartGame();
	}
	
	// Update is called once per frame
	void Update () {
		 if (Input.GetKeyDown(KeyCode.UpArrow)){

			 min = guess;
			 nextGuess();

		 }else if(Input.GetKeyDown(KeyCode.DownArrow)){			

			 max = guess;
			 nextGuess();

		 } else if(Input.GetKeyDown(KeyCode.Return)){
			 print("I won");
			 
			 StartGame();
		 }
	}

	void StartGame(){

		min = 1;
		 max = 1000;
		guess = 500;
		
		print("---------------------------");
		print("This is a number guessing game ");

		print("The max number you can Enter is "+max);
		print("The min number you can Enter is "+min);
		
		print(" Is the no > or <  "+guess + " ?");
		print("UP = higher , DOWN = lower , RETURN = equal ");

		max +=1;
	}

	void nextGuess(){

		 guess = ( min + max ) / 2;
		 print("Higher or lower than "+ guess + " ?");
		 print("UP = higher , DOWN = lower , RETURN = equal ");
	}
}
