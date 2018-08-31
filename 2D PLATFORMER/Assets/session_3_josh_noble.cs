using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System; //Math Library

public class session_3_josh_noble : MonoBehaviour {
    
    //Functions, Parameters, and Return Values
    public int add_two_numbers(int x, int y) //Function add_two_numbers. Parameters x and y.
    {
        return x + y; //Return value: x + y
    }

    public double pyth_thm(double a, double b) //Function pyth thm on two numbers.
    {
        return Math.Sqrt(a * a + b * b); //Return value: c = sqrt(a^2+b^2)
    }

    //Global Variables/Constants
    public const double GLOBAL_PI = 3.14159265359;

    //Text Files. Output to Text File. Read from Text File to string

    //Exception Handling. Try/Catch/Throw Statements

    // Use this for initialization
    void Start () {
        Debug.Log(add_two_numbers(1, 2)); //Outputs 3 to console
        Debug.Log(pyth_thm(3, 4)); //Outputs 5 to console
        Debug.Log(GLOBAL_PI);
        //GLOBAL_PI = 5; //Outputs error since trying to modify constant value
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
