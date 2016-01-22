using UnityEngine;
using System.Collections;
using System.IO;

public class Lab1 : MonoBehaviour {

    void Start()
    {
        int j = 37;
        int k;
        double p= 223.2;

        j=ThisIsAfunction(j);
        Debug.Log(j);
        print("Hello "+j);

    }

  private int ThisIsAfunction(int i) {
        char x = 'i';
        return i+1;
    }
}
