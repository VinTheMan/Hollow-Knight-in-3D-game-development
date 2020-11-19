using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlindDiscovery : MonoBehaviour {

    public AudioSource BlindSound ;

    private void OnDisable() {

        BlindSound.Play() ;

    } // 

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
