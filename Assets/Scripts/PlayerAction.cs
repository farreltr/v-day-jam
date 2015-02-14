using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerAction : MonoBehaviour
{

		// Affect Mood
		private List<string> phrases = new List<string> (3);
		private Room currentRoom;
		private SceneManager sceneManager;

		public void Update ()
		{
				currentRoom = sceneManager.GetRoomFor (this.name);
				if (currentRoom == Room.BEDROOM) {
						LoadInteraction ();
				}
		}


		public void AddPhrase (string phrase)
		{
				if (!phrases.Contains (phrase)) {
						phrases.Add (phrase);
				}
				
		}

		public void RemovePhrase (string phrase)
		{
				if (phrases.Contains (phrase)) {
						phrases.Remove (phrase);
				}
		
		}

		public void AddPhrase (string phrase)
		{
				phrases.Add (phrase);
		}

		public void ImproveMood (CharacterBehaviour character, int moodLevel)
		{
				character.IncreaseHappiness (moodLevel);
		}

		public void DisimproveMood (CharacterBehaviour character, int moodLevel)
		{
				character.DecreaseHappiness (moodLevel);
		}

		public void LoadInteraction ()
		{
				
		}
}
