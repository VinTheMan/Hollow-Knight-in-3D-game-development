using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamerafrontdoor : MonoBehaviour {

    public GameObject OriginMainCamera ;
    public GameObject ChangeCamera ;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerStay( Collider col ) {
        
        if ( col.tag == "Player" ) {

            OriginMainCamera.SetActive( false ) ;
            ChangeCamera.SetActive( true ) ;

        } // if

    }

    private void OnTriggerExit(Collider col) {
        
        if ( col.tag == "Player" ) {

            OriginMainCamera.SetActive( true ) ;
            ChangeCamera.SetActive( false ) ;

        } // if

    }
}
