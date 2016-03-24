using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EnemyDamage : MonoBehaviour
{
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
