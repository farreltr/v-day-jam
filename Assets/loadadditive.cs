using UnityEngine;
using System.Collections;

public class loadadditive : MonoBehaviour {

    int numberRooms = 2;
    int x;
    GameObject Scene;
	// Use this for initialization
	void Start () {
        for (x = 1; x <= numberRooms; x++)
        {

            Application.LoadLevelAdditive(x);   
        }
      
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
