using UnityEngine;
using System.Collections;

public class Arrays : MonoBehaviour {

    public int[] Hppy = { 3,4,5,6};


	// Use this for initialization
	void Start () {
        Hppy[0] = 34;

        for (int i = 0; i<Hppy.Length; i++) {
            Hppy[i] = i + 33;
            print(Hppy[i]);
        }

	}
	
	// Update is called once per frame
	void Update () {
        
	
	}
}
