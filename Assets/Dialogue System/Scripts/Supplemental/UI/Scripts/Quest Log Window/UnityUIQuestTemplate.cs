using UnityEngine;
//using UnityEngine.UI;
using PixelCrushers.DialogueSystem;

namespace PixelCrushers.DialogueSystem {

	/// <summary>
	/// This component hooks up the elements of a Unity UI quest template.
	/// Add it to your quest template and assign the properties.
	/// </summary>
	public class UnityUIQuestTemplate : MonoBehaviour	{

		public UnityEngine.UI.Button heading;

		public UnityEngine.UI.Text description;

		public UnityEngine.UI.Text entryDescription;

		public UnityEngine.UI.Button trackButton;

		public UnityEngine.UI.Button abandonButton;

		public bool ArePropertiesAssigned {
			get {
				return (heading != null) &&
					(description != null) && (entryDescription != null) &&
					(trackButton != null) && (abandonButton != null);
			}
		}

	}

}
