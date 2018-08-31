using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class session_2_josh_noble : MonoBehaviour {
    /*
     * Session 2 Overview
     * Sequence Operators
     *      -types of sequences. arrays and lists (stick to arrays)
     *      -array access
     * Slicing/Splicing a string
     * Constants
    */

    const int constant_number = 5;

    //Integer array example
    int[] my_array = new int[5];

	// Use this for initialization 
	void Start () {
        //Array access
        my_array[3] = 6; //Set fourth element to 6

        //"Slicing/Splicing" (in C# its creating a substring)
        string word = "Josh Noble";
        Debug.Log(word); //Output to console
        string word2 = word.Substring(0, 1); //Character 0 up to but not including 1
        Debug.Log(word2);
        string word3 = word.Substring(0, 4); //Splicing the string to only include first name
        Debug.Log(word3);

        //For loop example
        for (int i = 0; i < 5; i++)
        {
            my_array[i] = i;
            print(my_array[i]);
        }

        //Assignment 2 - Q1 Create an array of size 6 containing odd values
        int[] hw_array = new int[6];
        hw_array[0] = 1;
        hw_array[1] = 3;
        hw_array[2] = 5;
        hw_array[3] = 7;
        hw_array[4] = 1;
        hw_array[5] = 1;

        //Assignment 2 - Q2 Create a for loop that iterates 4 times
        for(int i = 0; i < 4; i++)
        {

        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
