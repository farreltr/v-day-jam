using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SceneManager : MonoBehaviour {

    int numberRooms = 2;
    int x;
    GameObject Scene;
    int currentSceneNumber;
    public Dictionary<string, Room> playerRoomManager;
	// Use this for initialization

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
	void Start () {

        Dictionary<string, Room> playerRoomManager = new Dictionary<string, Room>();
        Debug.Log(Application.loadedLevel);

        for (x = 0; x <= numberRooms; x++)
        {
            if (x == currentSceneNumber)
            {

            }
            else
            {
                Application.LoadLevelAdditive(x);   
            }
            
        }
      
	}

 

	public Room GetRoomFor(string name){
		if(playerRoomManager.ContainsKey(name)){
			Room room = playerRoomManager.TryGetValue(name, Room);
			return room;
		}
	}


	
	// Update is called once per frame
	void Update () {
        currentSceneNumber = Application.loadedLevel;
        Debug.Log("Current Scene Number: " + currentSceneNumber);
	}
}
