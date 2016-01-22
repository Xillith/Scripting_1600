using UnityEngine;
using System.Collections;

public class Lab2 : MonoBehaviour {
    // Use this for initialization
 

    void Start()
    {
        //int j;

        int whatsthis = RandomRolling(5);
        print(" Hmm " + whatsthis);


    }

    static int RandomRolling(int How_Many_D6)
    {

        print("I do nothing with this! " + How_Many_D6);

        return 42;
    }


}
