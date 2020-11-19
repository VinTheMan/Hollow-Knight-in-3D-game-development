using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchThisDestoryThing : MonoBehaviour {

    public GameObject Destory1 ;
    public AudioSource voice ;
    public AudioSource voice2 ;
    public ParticleSystem Effect ;
    public GameObject Blinding ;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
        
	}

    private void OnTriggerEnter(Collider col) {
        
        if ( col.tag == "Player" ) {

            voice.Play();
            InvokeRepeating("CallNextSound", 0.3f, 0.3f) ;

        }

    }

    private void CallNextSound() {

        voice2.Play() ;
        Effect.Play() ;
        Destory1.SetActive(false) ;

        CancelInvoke("CallNextSound");
        gameObject.SetActive(false) ;
        Blinding.SetActive(false) ;

    }

}
