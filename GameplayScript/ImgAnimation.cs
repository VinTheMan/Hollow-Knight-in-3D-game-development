using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImgAnimation : MonoBehaviour {

    public bool havenextImg = true ;
    public GameObject nextImg ;
    private void OnEnable() {
        InvokeRepeating("CallNextImg", 0.05f, 0.05f) ;
    }

    private void CallNextImg() {
        if ( havenextImg )
            nextImg.SetActive(true) ;

        gameObject.SetActive(false);
        CancelInvoke("CallNextImg");
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
