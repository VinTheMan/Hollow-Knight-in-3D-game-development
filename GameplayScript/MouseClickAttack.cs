using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClickAttack : MonoBehaviour {

    private bool isMouseDrag ;
    private bool oneAtkFin ;
    private Vector3 screenPosition ;
    private float offset_left ;
	
	// Update is called once per frame
	void Update () {
    
        if ( Input.GetMouseButtonDown(0) ) {
            screenPosition = Input.mousePosition ;
            isMouseDrag = true ;
        }
		else if ( !oneAtkFin && Input.GetMouseButton(0) ) {
            offset_left = screenPosition.y - Input.mousePosition.y ;
            // Debug.Log(offset) ;
        }
        else if ( !oneAtkFin && Input.GetMouseButtonUp(0) ){
            isMouseDrag = false ;
            oneAtkFin = true ;
        }

        if ( oneAtkFin && !isMouseDrag && offset_left < -15 ) {
            Debug.Log("upper attack");
            oneAtkFin = false ;
            offset_left = 0 ;
        }
        else if ( oneAtkFin && !isMouseDrag && offset_left > 15 ){
            Debug.Log("down attack");
            oneAtkFin = false;
            offset_left = 0 ;
        }
        else if ( oneAtkFin && !isMouseDrag ) {
            Debug.Log("normal attack");
            oneAtkFin = false ;
            offset_left = 0 ;
        }

	}


}
