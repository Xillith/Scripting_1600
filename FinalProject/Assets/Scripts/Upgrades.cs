using UnityEngine;
using System.Collections;

public class Upgrades : MonoBehaviour
{
    public GameObject HealthBar;
    private GameObject Player;
    public AudioClip DestructoClip;
    // Use this for initialization
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider ObjHit)
    {
        //Run code here
        if (ObjHit.tag == "Player")
        {
           PlayerHealth playerhlth= ObjHit.transform.GetComponent<PlayerHealth>();
            playerhlth.resetHealth();
            //playerhlth.addUpgrade();
            PlayerControl playercont = ObjHit.transform.GetComponent<PlayerControl>();
            playercont.CurrentBuff++;
            AudioSource.PlayClipAtPoint(DestructoClip, Player.transform.position, 1f);
            Destroy(gameObject);
        }
    }
}
