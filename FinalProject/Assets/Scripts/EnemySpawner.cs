using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {
    /* 
     * Variables:
     * A public array of GameObjects that holds the references to the enemy prefabs
     * A private float for the invoking delay
     */
	
    public GameObject[] Enemies;
    private float delay;

    /*
     * The Start function, void return type, no parameters
     *      Assign a value to the delay variable
     *      Use InvokeRepeating to repeatedly call the spawn function. Put the name of the spawn function, 0, and the delay variable as parameters
     */
    void Start() {
        delay = 3;
        InvokeRepeating("Spawn", 0, delay);

    }

    void Spawn() {
        int spawnz = 0;
        while (spawnz < Enemies.Length) {
            Vector3 EnemyPos = transform.position;
            EnemyPos.x += spawnz;
            EnemyPos.z += Random.Range(-2,2);
            Instantiate(Enemies[spawnz], EnemyPos, Quaternion.identity);
            spawnz++;
        }
    }

    /*
     * A function for spawning the enemies, void return type, no parameters
     *      Create an int variable and assign it zero.
     *      while ( Check if the int variable is less then the size of the enemies array)
     *          create a new Vector3 variable and assign this GameObject's position to it
     *          Have the x value of the Vector3 variable "plus equals" the int variable
     *          Instantiate the current enemy using the array with the int variable, the Vector3 variable, and Quaternion.identity
     *          Increment the int variable
     */

    /* **************Explanation and Hints************
     * GameObject - They are the objects placed in a scene such as a Cube or an Empty Object. We also
     *              place these scripts on GameObjects.
     *              
     * Array - We will learn more about them later. For now it's important to know that they are
     *         a collection of things. In this script we want the array to contain the prefabs of the
     *         enemies. We need this so that we can instantiate them.
     *         
     *       - To make an array of the enemy prefabs we will type:
     *       
     *         public GameObject[] *nameOfArray*;
     *         
     *         Replace *nameOfArray* with your own name for the array;
     *         
     *       - In the while loop's conditional we need to get the size of the array. We do this by typing:
     *       
     *         *nameOfArray*.Length
     *         
     *       - To get a value out of the array we need an int variable. We would type it out like this:
     *       
     *         *nameOfArray*[*intVariable*]
     *         
     *         Replace *nameOfArray* with the name you have given the array. Replace *index* with the name
     *         you have given the index.
     *         
     * plus equals - To write code faster we can take some shortcuts such as the plus equals. To use it
     *               type the following:
     *               
     *               *variableName* += *value*
     *               
     *               This is taking the value in variableName and adding *value* to it. It is then taking
     *               the new value and putting it back into variable name. For example:
     *               
     *               int num = 2;
     *               num += 5;
     *               
     *               After running this num will now have the value of 7.
     *         
     * Prefab - They are GameObjects that are stored outside of the scene. We use them to instantiate
     *          GameObjects.
     *          
     * InvokeRepeating - It is a special function that will call the specified function over and over again at a set interval.
     *                   In this script we want to do this so that enemies will spawn at a set fequency.
     *                 - Type this to use it:
     *                 
     *                   InvokeRepeating("nameOfFunction", 0, *delayVariable*);
     *                   
     *                   Replace nameOfFunction with the name of the spawning function. Be aware that when
     *                   typing in the name of the function we will put double quotes at the beginning
     *                   and end of the name in order to make it a string. Replace *delayVariable* with
     *                   the delay variable that we have created above.
     *     
     * Vector3 - It's a variable that groups "x", "y", and "z" together. In this script we want to save the
     *           GameObject's position to it. We can do this by typing:
     *           
     *           Vector3 *name* = transform.position
     * 
     *           Make sure that transform has a lowercase 't'.
     *          
     * Instantiate - This will create a new GameObject or prefab of our choosing. In this script we want to
     *               use the array with an int, a position, and Quaternion.identity. 
     *             - To create the enemies we'll type:
     *             
     *               Instantiate(*nameOfArray*[*int*], *aVector3ToSetThePosition*, Quaternion.identity);
     *               
     *               Replace *nameOfArray* with the name you have given the array. Replace *index* with the name
     *               you have given the index. Replace *aVector3ToSetThePosition* with the Vector3 variable that has
     *               this GameObjects position.
     *               
     * Incrementing - This will increase the value of an int variable by one. It is typed like this:
     *                *intVariable*++;
     */
}
