using UnityEngine;
using System.Collections;

public class Enumerations : MonoBehaviour {
 
    enum Directions  {North, South, East, Dude};

	// Use this for initialization
	void Start () {
        Directions thisIsAVar = Directions.North;
        Debug.Log(thisIsAVar);
        thisIsAVar =aFunctrion(thisIsAVar);

        Debug.Log(thisIsAVar);


    }

    Directions aFunctrion(Directions grr) {

        if (grr == Directions.North)
            return Directions.South;
        else return Directions.East;

    }

	
}













