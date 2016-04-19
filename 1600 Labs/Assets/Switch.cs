using UnityEngine;
using System.Collections;

public class Switch : MonoBehaviour {

 public   int Temperature = 300;

	// Use this for initialization
	void Start () {

        switch (Temperature){
            case 300:
                    print("Im At 300");
                break;
            case 234:
                print("Im At 234");
                break;
            default:
                print("Frozen");
                break;




        }


	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
