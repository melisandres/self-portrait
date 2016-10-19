using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class seen_by_camera : MonoBehaviour 
{
	public bool isSeen;
	public Image recordLight;
	public Button  itch;

	void OnTriggerEnter ()
	{
		isSeen = true;
		recordLight.enabled = true;
		itch.GetComponent<scratch_yourself> ().isSeen = true;

	}

	void OnTriggerStay()
	{
		isSeen = true;
		recordLight.enabled = true;
		itch.GetComponent<scratch_yourself> ().isSeen = true;

	}

	void OnTriggerExit()
	{
		isSeen = false;
		recordLight.enabled = false;
		itch.GetComponent<scratch_yourself> ().isSeen = false;

	}

}
