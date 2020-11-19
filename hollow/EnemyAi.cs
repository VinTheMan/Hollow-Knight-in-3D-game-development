using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI ; 
public class EnemyAi : MonoBehaviour {

	public float lookRadius = 10f ;
	public Transform target ;
	NavMeshAgent agent ;
	// Use this for initialization
	void Start () {
		// target =GetComponent<Transform>() ;
		agent = GetComponent<NavMeshAgent>() ; 
	}
	
	// Update is called once per frame
	void Update () {
		float distance = Vector3.Distance(target.position,transform.position) ;
		if(distance <= lookRadius){
			FaceTarget();
			agent.SetDestination(target.position) ;
			if(distance <= agent.stoppingDistance) {
				// Attack the target 
				//face the target
				FaceTarget();
			}
		}
	}


	void FaceTarget () {
		Vector3 directon = (target.position -transform.position).normalized;
		Quaternion lookRotation = Quaternion.LookRotation(new Vector3(directon.x, 0,directon.z));
		transform.rotation = Quaternion.Slerp(this.transform.rotation, lookRotation, Time.deltaTime*5f);
	}
	void OnDrawGizmosSelected()
	{
		Gizmos.color = Color.red ; 
		Gizmos.DrawWireSphere(transform.position, lookRadius) ;
	}
}
