using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EnemyDamage : MonoBehaviour
{


    public enum EnemyTypes { WeakEnemy, OkEnemy, StrongEnemy };
    public EnemyTypes MyTypes;
    public int EnemyHealth;
    public int Attacks;
    private GameObject Player;
    public AudioClip DestructoClip;

        void Start() {
        Player = GameObject.FindGameObjectWithTag("Player");

    }

    /*
    * Additional Variables:
    * A public enum that will contain constants for three different types of enemys
    * A public variable with the type being the enum above. This will determine what type of enemy this one is.
    * A public int for the enemy's health
    */

    /*
    * A damage function, void return type, parameters: an int for damage amount
    *       Have the health "subtract equals" the parameter that was passed in.
    *       if(the health variable is less than 0)
    *           Destroy this enemy
    */

    /* **************Explanation and Hints************ 
    * Subtract equals - This will take a variable and subtract a certain amount from it. For example:
    *                         
    *                   *healthVariable* -= *damageAmount*
    *                         
    *                   So if the health variable equals 15 and damage amount equal five then after running this line of
    *                   code the health variable will now equal 10
    * Destroy this game object - When the enemy has lost all of it's health we want it to be destroyed. We can do this by typing the following:
    *                            
    *                            Destroy(gameObject);
    */


    public bool DamageTaken(int Damage) {
        EnemyHealth -= Damage;
        AudioClip clip=GetComponent< AudioSource>().clip;
        AudioSource.PlayClipAtPoint(clip, Player.transform.position,.7f);
        if (EnemyHealth <= 0) {
            AudioSource.PlayClipAtPoint(DestructoClip, Player.transform.position,10f);
            Destroy(gameObject);
            return true;
        }
        return false;

    }







    /*
     * The OnCollisionEnter function, void return type, parameters: Collision
     *      If (the tag of the Collision parameter equals the KillZone tag)
     *          Destroy this GameObject
     */
    void OnCollisionEnter(Collision hitz)
       {
                           //Run code here
            if (hitz.transform.tag=="KillZone"){
                Destroy(gameObject);
            }
       }

    /* **************Explanation and Hints************
     * OnCollisionEnter - This is a special Unity function. It runs whenever a GameObject with rigidbody attached to it
     *                    runs into another object. In this script we are using it to detect when the enemy runs into
     *                    the kill zone. One thing this function needs is a Collision parameter. The collision
     *                    parameter is useful because it gives us the reference of whatever the enemy hits. The function
     *                    is typed like this: 
     *                    
     *                    void OnCollisionEnter(Collision *name*)
     *                    {
     *                        //Run code here
     *                    }
     *                    
     *                    Replce *name* with what you want to call the Collision variable
     *                    
     * Tag - Tags are used to identify GameObjects. In the inspector we can create new tags and set tags for GameObjects.
     *       In this project we will want to create two tags. First one is "Enemy" and the second one is "KillZone". Then
     *       we want to give the enemies the "Enemy" tag, give the player the "Player" tag, and give the KillZone the
     *       "KillZone" tag.
     *     - In the OnCollisionEnter function we will type If statements. The conditionals of these if statements will be
     *       comparing the passed in Collision variable's tag with the strings "Enemy" or the KillZone. We do this so
     *       we know what the player has hit. You will type out these If statements in the OnCollisionEnter function
     *       like this:
     *       
     *       If(*collisionVariable*.transform.tag == "type the tag name here")
     *       {
     *          //Do stuff when this hits an GameObject with the tag specified above
     *       }
     *       
     *       Replace *collisionVariable* with the name that you have given the Collision variable. Type the tag
     *       name between the double quotes.
     *       
     * Destroy - This function will destroy whatever GameObject we pass in as a parameter. For example we
     *           will type:
     *           
     *           Destroy(gameObject);
     *           
     *           This will destroy the GameObject that this script is attached to. For our project we want
     *           to use this along with the timer so that the enemies that have spawned don't stick around
     *           forever.
     */
}
