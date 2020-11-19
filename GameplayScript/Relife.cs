using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayerControl;

namespace GameplayScript.relifeSet {

    public class Relife : MonoBehaviour {

        public GameObject relifePoint ;
        public ParticleSystem relifeEffect ; // this particleSystem 
                                             // should put under hero object ;
        public GameObject UISaveing ;
        public PlayerControl.PlayerScript.PlayerSetting hero ;
        public AudioSource savingSound ;
        public GameObject heroObject ;
        private int countdown = 0 ;

        public void FlashRelifePoint( GameObject benchplace ) {
            relifePoint = benchplace ;
            hero.GetHealingFromBench();
            hero.SetHP(hero.GetMaxHP());
            hero.GetHealingFromBenchEnd();
            savingSound.Play() ;
            relifeEffect.Play() ;
            UISaveing.SetActive(true) ;
        } // FlashRelifePoint()

        // Use this for initialization
        void Start() {
            
        }

        // Update is called once per frame
        void Update() {

            if ( hero.GetHP() == 0 ) {

                hero.SetOutcomeGeoNeg(-hero.GetGeo());
                InvokeRepeating( "Relifing", 2, 2 ) ;
                
            }

        }
        void Relifing() {
            countdown++;

            if (countdown == 1) {
                hero.SetHP(hero.GetMaxHP());
                hero.SetGeo(0);
                // must save the origin geo after the shadow is finished

                hero.SetSoul(0);
                // must set max after the shadow is finished ;

                heroObject.transform.position = relifePoint.transform.position;
                countdown = 0 ;
                CancelInvoke("Relifing");
            }
        }
    }

}