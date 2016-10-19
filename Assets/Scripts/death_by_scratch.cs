using UnityEngine;
using System.Collections;

public class death_by_scratch : MonoBehaviour 
{
	public GameObject itchButton;
	//public GameObject endScreen;

	void Update()
	{
		if (itchButton.GetComponent<scratch_yourself> ().recordedScratch > 5) 
		{
			
			//and send the scratch text to the end screen manager
		}
	}
}
