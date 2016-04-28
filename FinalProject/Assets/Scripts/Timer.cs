using UnityEngine;
using System.Collections;
using System;

public class Timer : MonoBehaviour {
    /* 
     * Variables:
     * A public float for the amount of time
     */
    public float time = 5;

    /*
     * The Update function, void return type, no parameters
     *      Call the check timer function
     */
    void Update() {
        time -= Time.deltaTime;
        CheckTimer();
    }

    private void CheckTimer()
    {
        if (time < 0) {
            Destroy(gameObject);
        }
    }

    /*
     * The check timer function, void return type, no parameters
     *      Have the time variable "subtract equals" Time.deltaTime
     *      If (the time variable is less than zero)
     *          then destroy this GameObject
     */

    /* **************Explanation and Hints************
     * subtract equals - To write code faster we can take some shortcuts such as the subtract equals. To use it
     *                   type the following:
     *               
     *                   *variableName* -= *value*
     *               
     *                   This is taking the value in variableName and subtracting *value* from it. It is then taking
     *                   the new value and putting it back into variable name. For example:
     *               
     *                   int num = 10;
     *                   num -= 2;
     *               
     *               After running this num will now have the value of 8.
     * deltaTime - deltaTime will give you the time that has passed since the last frame was rendered.
     *             What is important about this variable is that using this inside the Update function
     *             or a function that is called within the Update function will allow you to decrease or
     *             increase a value in real seconds. In this script we are using it as a timer to decrease
     *             the timer until it reaches zero.
     * Destroy - This function will destroy whatever GameObject we pass in as a parameter. For example we
     *           can type:
     *           
     *           Destroy(gameObject);
     *           
     *           This will destroy the GameObject that this script is attached to. For our project we want
     *           to use this along with the timer so that the enemies that have spawned don't stick around
     *           forever.
     */
}
