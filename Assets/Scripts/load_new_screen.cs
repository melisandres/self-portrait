using UnityEngine;
using System.Collections;

public class load_new_screen : MonoBehaviour
{
	public bool canSwitchScreens = true;
	public bool hasSeenTutorial = false;

	public GameObject startScreen;
	public GameObject tutorialScreen;

	void Start()
	{
		startScreen.SetActive (true);
	}


	public void LoadNextScreen()
	{
		if (canSwitchScreens && !hasSeenTutorial) 
		{
			startScreen.SetActive (false);
			tutorialScreen.SetActive (true);
			hasSeenTutorial = true;
		}
		else if (canSwitchScreens && hasSeenTutorial) 
		{
			tutorialScreen.SetActive (false);
			gameObject.GetComponent<timer> ().gameHasStarted = true;
			canSwitchScreens = false;
		}
	}
}
