using UnityEngine;
using System.Collections;

public class CharacterMovement : MonoBehaviour {
	public Transform destination;
	public GameObject waypoints;
	private NavMeshAgent agent;
	private int numWaypoints;
	private float time;

	void Start(){
		agent = GetComponent<NavMeshAgent>();
		numWaypoints = waypoints.transform.childCount;
		time = Time.time;
	}
	
	void Update(){
		transform.rotation = Quaternion.Euler(transform.rotation.x, 0, transform.rotation.z);
		if((Time.time - time) > 5){
			agent.SetDestination(nextWaypoint().position);
			time = Time.time;
		}
		//scale the thing based on its 
	}

	private Transform nextWaypoint(){
		return waypoints.transform.GetChild(Random.Range(0, numWaypoints));
		//return waypoint.position
	}
}
