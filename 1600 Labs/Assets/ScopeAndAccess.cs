using UnityEngine;
using System.Collections;

public class ScopeAndAccess : MonoBehaviour {

    private int i = 4;

	// Use this for initialization
	void Start () {
        int i = 77;

        while (i > 44) { i--;
            print(i);
        }
     
	}
	
	// Update is called once per frame
	void Update () {

        if (i == 4) { print("Huzzah! i="+i); i++;
            print("Huzzah, now i=" + i);
        }
	    
	}
}
