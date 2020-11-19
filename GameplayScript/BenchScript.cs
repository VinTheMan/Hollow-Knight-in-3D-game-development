using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameplayScript ;

public class BenchScript : MonoBehaviour {

    public GameplayScript.relifeSet.Relife relifeScriptCall ; // here put the hero data
    public GameObject onBenchImg ;
    public GameObject benchself ;

    private bool sitting = false ;
    

    private void OnTriggerEnter(Collider col) {
        if ( col.tag == "Player" ) {
            onBenchImg.SetActive(true) ;
        }
    }
    private void OnTriggerExit(Collider col) {
        if ( col.tag == "Player" ) {
            onBenchImg.SetActive(false) ;
        }
    }
    private void OnTriggerStay(Collider col) {
        // Debug.Log( "Bench-Stay" ) ;
        if ( col.tag == "Player" ) {
            
            if ( Input.GetButton("ActionWithNPC") ) {
                if ( !sitting ) {
                    sitting = true ;
                    playerSit() ;
                    
                } // if
                else if ( sitting ) {
                    sitting = false ;


                } // else if 

            } // if

        } // if

    } // OnTriggerStay()

    public void playerSit() {

        relifeScriptCall.FlashRelifePoint( benchself ) ;

    } // playerSit() 

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
       
	}
}
