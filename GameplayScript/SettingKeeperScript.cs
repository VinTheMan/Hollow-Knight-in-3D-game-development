using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingKeeperScript : MonoBehaviour {

    public float Value ;
    public string name ;

    public void SetV( float _f ) {

        Value = _f;

    } 

    public string getString() {

        return name ;

    }
    public float getV() {
        return Value ;
    }

	// Use this for initialization
	void Start () {

        DontDestroyOnLoad(gameObject) ;

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
