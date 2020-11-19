using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetSpeedY : MonoBehaviour {
	Rigidbody controller;
	Animator m_Animator;

	// Use this for initialization
	void Start () {
		controller = GetComponent<Rigidbody>();
		m_Animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		// The speed on the x-z plane ignoring any speed
		float horizontalSpeed = controller.velocity.x;
		// The speed from gravity or jumping
		float verticalSpeed  = controller.velocity.y;
        // The overall speed
		float overallSpeed = controller.velocity.magnitude;

		if( verticalSpeed <= 0 ) {
			m_Animator.SetBool("Falling", true) ; 
		} // if 
		else {
			m_Animator.SetBool("Falling", false) ; 
		} // else 
	}
}
