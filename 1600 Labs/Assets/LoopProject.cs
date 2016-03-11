using UnityEngine;
using System.Collections;

public class LoopProject : MonoBehaviour {

	// Use this for initialization
	void Start () {
        string[] strings = new string[3];
        strings[0] = "First string";
        strings[1] = "Second string";
        strings[2] = "Third string";
        int j = 0;

        foreach (string Temp in strings) {
            print(Temp);
        }
        for (int i = 5; i > 0; i--) {
            print("HI");
        }
        
        while (j < 10) {
            j++;
            print(j);
        }
        int k = 1;
        do { print("k: " + k);
            k++;
        }
        while (k < 10);

    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
