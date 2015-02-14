using UnityEngine;
using System.Collections;

public class CharacterBehaviour : MonoBehaviour
{

		private int mood = 50;
		private SpriteRenderer renderer;
		public Sprite happySprite;
		public Sprite sadSprite;
		public Sprite neutralSprite;

		enum Mood
		{
				SAD,
				HAPPY,
				NEUTRAL
		}

		void OnAwake ()
		{
				DontDestroyOnLoad (gameObject);
		}
		
	
		void Start ()
		{
				mood = 50;
				renderer = gameObject.GetComponent<SpriteRenderer> ();

		}

		void Update ()
		{
				switch (GetMood ()) {
				case Mood.NEUTRAL:
						{						
								renderer.sprite = neutralSprite;
								break;
						}

				case Mood.HAPPY:
						{
								renderer.sprite = neutralSprite;
								break;

						}
				case Mood.SAD:
						{
								renderer.sprite = sadSprite;
								break;
						}
				}
		}

		public void DecreaseHappiness (int n)
		{
				mood -= n;
		}

	
		public void IncreaseHappiness (int n)
		{
				mood += n;
		}

		private Mood GetMood ()
		{
				if (mood >= 0 && mood < 30) {
						return Mood.SAD;
				} else if (mood >= 30 && mood < 70) {
						return Mood.NEUTRAL;
				}
                return Mood.HAPPY;

		}
}
