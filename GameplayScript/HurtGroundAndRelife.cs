using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayerControl ;

public class HurtGroundAndRelife : MonoBehaviour {

    public GameObject relifePoint ;
    public PlayerControl.PlayerScript.PlayerSetting hero ;

    private void OnTriggerEnter(Collider col) {
        if ( col.tag == "Player" ) {
            
            hero.HurtHero();
            if ( hero.GetHP() != 0 )
                col.transform.position = relifePoint.transform.position ;
            
        }

    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
