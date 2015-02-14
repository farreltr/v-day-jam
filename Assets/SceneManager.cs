using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SceneManager : MonoBehaviour {

    int numberRooms = 2;
    int x;
    GameObject Scene;
    int currentSceneNumber;
    public Dictionary<string, Room> playerRoomManager;
    Camera currentCam;
    Camera previousCam;
   
	// Use this for initialization

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }


   void SetCamera()
   {
    previousCam = currentCam;
    currentCam = GameObject.Find("Scene " + currentSceneNumber).GetComponentInChildren<Camera>();
    currentCam.tag = "MainCamera";

    if (currentCam != previousCam)  
    {
          previousCam.tag = "Disabled";
    }
    }

   
	void Start () {
         playerRoomManager = new Dictionary<string, Room>();
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
        Room room = Room.DINING_ROOM;
		if(playerRoomManager.ContainsKey(name)){

			playerRoomManager.TryGetValue(name,out room);
			
		}
        return room;
	}

    
	
	// Update is called once per frame
	void Update () {
        currentSceneNumber = Application.loadedLevel;
        Debug.Log("Current Scene Number: " + currentSceneNumber);

        SetCamera();


	}
}
