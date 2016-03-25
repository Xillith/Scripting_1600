using UnityEngine;
using System.Collections;

public class ClassPages : MonoBehaviour {

    public class ThisIsAClass {

        public int hi;
        public int low;
        public ThisIsAClass() {
            hi = 10;
            low = 5; }
        public ThisIsAClass(int H, int L)
        {
            hi = H;
            low = L;
        }


    }

	// Use this for initialization
	void Start () {

        ThisIsAClass ThisClass = new ThisIsAClass(45, 2);

        ThisIsAClass cls2 = ThisClass;

        cls2.hi = 15;
        

	}
	
	// Update is called once per frame
	void Update () {
	
	}


  
}
