using UnityEngine;
using System.Collections;
using System;

public class PlayerHealth : MonoBehaviour {
    /* 
     * Variables:
     * A public Text for the health text
     * A private int for the health
     * A private int for the damage amount
     */
    public TextMesh Health, Points;
    public TextMesh LoseText, RestartTxt;
    public GameObject HealthBar;
    private int HP;
    private int Damage;
    private int POINTS;
    private int NextBonus;
    public GameObject SpawnUpgrade;
    public GameObject SpawnTree;
    public AudioClip ImHit;

    internal void resetHealth()
    {
        while (HP < 100)
        {
            HealthBar.transform.localScale -= new Vector3(-.59f, 0, 0);
            HealthBar.transform.Translate(.45f, 0, 0, Space.Self);
            HP += Damage;
        }
        Health.text = "Health: " + HP + "/100";

    }

 

    public void AddPoints(int points) {
        POINTS += points;
        if (POINTS >= NextBonus) {
            System.Random random = new System.Random();
            int randomNumber = random.Next(-30, 30);
            int randomNumber2 = random.Next(-30, 30);

            Vector3 PositUpgrd = new Vector3(randomNumber, 1.37f, randomNumber2);
            Instantiate(SpawnUpgrade, PositUpgrd, SpawnUpgrade.transform.rotation);

            randomNumber = random.Next(-30, 30);
            randomNumber2 = random.Next(-30, 30);
            PositUpgrd = new Vector3(randomNumber, 0, randomNumber2);
            Instantiate(SpawnTree, PositUpgrd, SpawnTree.transform.rotation);

            NextBonus = NextBonus*2;
        }
        

    }
    /*
     * The Start function, void return type, no parameters
     *      Set the initial value for the health variable
     *      Set the initial value for the damage variable
     */
    void Start() {
        HP = 100;
        Damage = 10;
        Health.text = "Health: " + HP+"/100";
        LoseText.text = "";
        RestartTxt.text = "";
        Points.text = "Points: 0";
        POINTS = 0;
        NextBonus = 1000;



    }


    /*
     * The OnCollisionEnter function, void return type, parameter: Collision
     *      If (tag of the Collision parameter equals the enemy tag) 
     *          -then call the damage function from below. Pass the health variable as 
     *              the parameter. Put the returning value from that function back into the
     *              health variable so that the value for the health variable is lowered.
     *          -Have the text value of the "health text" variable equal to the health variable
     *      Else if the tag of the Collision parameter equals the kill zone tag then
     *          -Reload the level
     */

    void OnCollisionEnter(Collision Hit) {
        if (Hit.transform.tag == "Enemy")
        {
            AudioSource.PlayClipAtPoint(ImHit, transform.position, 10f);
            // print("Enemy "+Hit.gameObject.GetType());
            EnemyDamage Enemy= Hit.transform.GetComponent<EnemyDamage>();

            if (HP > 0)
            {
                HP -= Damage;
                Health.text = "Health: " + HP + "/100";
                HealthBar.transform.localScale -=new Vector3(.59f,0,0) ;
                HealthBar.transform.Translate(-.45f, 0,0,Space.Self);

            }
            if (HP <= 0) {
                LoseText.text = "You Lose...";
                RestartTxt.text = "Press Enter key To Try Again";
                PlayerControl.GameOver = true;
            }

            //When hit a certain number of times by an enemy, that enemy dies without giving you points.
            if (Enemy.Attacks == 1)
            {
                Destroy(Enemy.gameObject);
            }
            else {
                Enemy.Attacks--;
            }
           

            
            //Call Damage Function
            //Set Health Text, unless you lose. Then you lose. 
        }
        else if (Hit.transform.tag == "KillZone") {
            LoseText.text = "You Lose...";
            RestartTxt.text = "Press Enter key To Try Again";
            PlayerControl.GameOver = true;
            //GoTo You Lose Function
        }
    }

    internal void RefreshPoints()
    {
        Points.text = "Points: "+POINTS;
        if (POINTS >= NextBonus) {

        }
    }

    //You Lose...
    //Press Space Bar To Try Again

    /* 
     * A damage function, int return type, parameter: int. Name this function whatever you want
     *      Create a variable for the new health value
     *      Have the new health variable equal the parameter variable minus the damage variable
     *      If (the new health value is less than 0)
     *          reload the level
     *      Lastly, return the new health variable
     */

    /* **************Explanation and Hints************
     * void - This is a return type. This means that a function will not return anything. To use this we will type
     *        "void" before the name of the function when we are writing out the whole function.
     *
     * Text - The Text component is used for UI text. In this script we want to display the current health on the
     *        screen. Using Text will help us do that. First of all you'll need to type 
     *
     *        using UnityEngine.UI; 
     *
     *        at the very top of this script. Then we need to have a Text variable. By itself the Text variable can't do
     *        anything. We need to assign the a Text reference to it. We can do it by making the Text variable public
     *        then in the inspector we can drag the Text object into our Text variable. So it will look like this:
     *      - To change what The Text variable displays we need to type 
     *
     *        *textVariableName*.text = "type something in here";
     *
     *                          or
     *
     *        *textVariableName*.text = *stringVariable*;
     *
     *                          or
     *
     *
     *        *textVariableName*.text = *intVariable*.ToString();
     *
     *        replace *intOrStringVariable* with an int or string variable.
     *         
     * OnCollisionEnter - This is a special Unity function. It runs whenever a GameObject with rigidbody attached to it
     *                    runs into another object. In this script we are using it to detect when the player runs into
     *                    an enemy or the kill zone. One thing this function needs is a Collision parameter. The collision
     *                    parameter is useful because it gives us the reference of whatever the player hits. The function
     *                    is typed like this:
     * 
     *                    void OnCollisionEnter(Collision *name*)
     *                    {
     *                        //Run code here
     *                    }
     *
     *                    Replce *name* with what you want to call the Collision variable
     * Tag - Tags are used to identify GameObjects. In the inspector we can create new tags and set tags for GameObjects.
     *       In this project we will want to create two tags. First one is "Enemy" and the second one is "KillZone". Then
     *       we want to give the enemies the "Enemy" tag, give the player the "Player" tag, and give the KillZone the
     *       "KillZone" tag.
     *     - In the OnCollisionEnter function we will type a few If statements. The conditionals of these if statements will be
     *       comparing the passed in Collision variable's tag with the strings "Enemy" or "KillZone". We do this so
     *       we know what the player has hit. You will type out these If statements in the OnCollisionEnter function
     *       like this:
     *
     *       If(*collisionVariable*.transform.tag == "Write the tag here")
     *       {
     *          //Do stuff when this hits an GameObject with the tag specified above
     *       }
     *
     *       Replace *collisionVariable* with the name that you have given the Collision variable. Replace *stringOfTag*
     *       with either the "Enemy" tag or the "KillZone" tag.
     * LoadLevel - This function belongs in the Application object which contains variable and functions about our game.
     *             We will use this to make it so that when the player hits the KillZone or looses all of it's health
     *             then we will start the level over again.
     *           - Before we can load a level we need to add our scene to the Build list. 
     *             Please watch the video to find out how to do this.
     *             Then, as a parameter, we will pass in the name of the scene or the index of the scene.
     *             To do this type:
     *            
     *             Application.LoadLevel(*indexOfScene*);
     *
     *                              or
     *
     *             Application.LoadLevel("Type the name of the scene here");
     *
     *             Replace *indexOfScene* with the name of the scene you want to load or it's index.
     */
}
