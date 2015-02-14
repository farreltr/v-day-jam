using UnityEngine;
using System.Collections;

public class CharacterMovement : MonoBehaviour {
	public GameObject waypoints;
	public GameObject exits;
	private NavMeshAgent agent;
	private Transform destination;
	private int numWaypoints;
	private int numExits;
	private bool characterActing;
	private int time;
	private bool movingRoom;
	private float scale;
	private bool isTalking;
	//var for room destination

	void Start(){
		agent = GetComponent<NavMeshAgent>();
		numWaypoints = waypoints.transform.childCount;
		numExits = exits.transform.childCount;
		characterActing = false;
		time = Mathf.RoundToInt(Time.time);
		movingRoom = false;
		transform.localScale = new Vector3(1-scale, 1-scale, 0);
		isTalking = false;
		
		//destination = waypoints.transform.GetChild(Random.Range(0, numWaypoints));
	}
	
	void Update(){
		transform.rotation = Quaternion.Euler(transform.rotation.x, 0, transform.rotation.z);
		scale = transform.localPosition.z/100;
		transform.localScale = new Vector3(1-scale, 1-scale, 0);
		transform.position += new Vector3(0, scale, 0);
		if(!characterActing){
			CharacterBehaviour();
		}else if(!agent.hasPath){
			if(Time.time - time >= 4){
				time = Mathf.RoundToInt(Time.time);
				characterActing = false;
			}
		}
		//scale the thing based on its 
	}

	private Transform nextWaypoint(){
		Transform x = waypoints.transform.GetChild(Random.Range(0, numWaypoints));
		while(x == destination){
			x = waypoints.transform.GetChild(Random.Range(0, numWaypoints));
		}
		return x;
	}

	private Transform randomExit(){
		Transform x = exits.transform.GetChild(Random.Range(0, numExits));
		return x;
	}

	public bool isMovingRoom(){
		return movingRoom;
	}

	private bool adjacentRoomOccupied(){
		return false;
	}

	private bool characterInRoom(){
		return false;
	}

	private bool characterEnteringRoom(){
		return false;
	}

	private Transform moveToOtherCharacterRoom(){
		//add the correct room
		Transform x = exits.transform.GetChild(Random.Range(0, numExits));
		return x;
	}

	//trigger to move to another room

	void CharacterBehaviour(){
		if(isTalking){
		//	continue talking
			//pass
		}else if(characterInRoom()){
		//	talk to character
			//pass
		}else if(characterEnteringRoom()){
		//	amble around
			destination = nextWaypoint();
			agent.SetDestination(destination.position);
			characterActing = true;
		//else if other character is in adjacent room:
		}else if(adjacentRoomOccupied()){
		//	move to adjacent room
			destination = moveToOtherCharacterRoom();
		}
		//else if character has been in room for too long:
		if(Time.time >= 10){
		//	move to another room
			Debug.Log("Moving");
			destination = randomExit();
			agent.SetDestination(destination.position);
			characterActing = true;	
		}else{
		//	amble around
			destination = nextWaypoint();
			agent.SetDestination(destination.position);
			characterActing = true;
		}
	}
}
