using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class session_4_josh_noble : MonoBehaviour {

    //What is a class? What is an object
    //In the Unity editor, whenever we create a script we create a new class.
    //We can create objects of these classes in other scripts. (create session_3_josh_noble object)
    public session_3_josh_noble obj; //Create an object of "session_3...". Note: Important to name scripts well
    public session_3_josh_noble obj2; //**If script with session3_... is enabled, Start() is executed and displayed

    //"self" and "init" -> Class variables and constructors
    public class fruits
    {
        public int num_in_fruit_basket = 15; //Amt of fruits in basket

        public void disp_fruit_basket_num()
        {
            int num_in_fruit_basket = 25;
            Debug.Log(num_in_fruit_basket); //displays 25
            Debug.Log(this.num_in_fruit_basket); //"this." is the equivalent of "self". Used to access class variable
        }
    }

    public class pyth_thm
    {
        double x, y;
        public pyth_thm()//Constructor setting x = 0, y = 0
        {
            x = 0;
            y = 0;
        }

        public pyth_thm(double x, double y) //Constructor setting x and y values
        {
            this.x = x;
            this.y = y;
        }

        public void calc_hypot()
        {
            Debug.Log(Math.Sqrt(x * x + y * y));
        }
    }
    public pyth_thm obj4 = new pyth_thm(); //Create object using constructor with no values
    public pyth_thm obj5 = new pyth_thm(3, 4); //Create object using constructor with values
    public fruits obj3 = new fruits();
    // Use this for initialization
    void Start () {
        Debug.Log(obj.add_two_numbers(5, 6)); //Will display 11
        //Debug.Log(obj.GLOBAL_PI);
        obj3.disp_fruit_basket_num();
        obj4.calc_hypot();
        obj5.calc_hypot();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
