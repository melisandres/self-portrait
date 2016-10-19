using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class end_manager : MonoBehaviour 
{
	public GameObject doorsListCube;
	public GameObject myItch;
	public bool deathByScratch = false;
	public bool deathByTimer = false;

	public bool lockedEverything;
	public bool oneDoor;

	public bool itsDone = false;

	public GameObject endPanel;

	//now for the text slots 

	public Text youWinLose;
	public Text doors;
	//public Text embarrassement;
	public Text consequences;

	[HideInInspector] public static string deathByScratching = "You lose.";
	[HideInInspector] public static string deathByTiming = "You made it.";



	void Update () 
	{
		if (myItch.GetComponent<scratch_yourself> ().recordedScratch >= 5 && !itsDone) 
		{
			deathByScratch = true;
			gameObject.GetComponent<timer> ().gameHasStarted = false;
			PrintEnding ();
			itsDone = true;
		}
	}

	public void PrintEnding()
	{
		endPanel.SetActive (true);	

		//how did you die?
		if (deathByScratch) 
		{
			youWinLose.GetComponent<Text> ().text = deathByScratching;
		} 
		else if (deathByTimer) 
		{
			youWinLose.GetComponent<Text> ().text = deathByTiming;
		}

		//how many doors did you leave open?
		if (doorsListCube.GetComponent<doors_list_controller> ().doorsUnlocked > 0) 
		{
			int numDoor = doorsListCube.GetComponent<doors_list_controller> ().doorsUnlocked;
			if (numDoor > 1) 
			{
				doors.GetComponent<Text> ().text = "You left " + numDoor + " doors unlocked!";
			} 
			else 
			{
				doors.GetComponent<Text> ().text = "You left a door unlocked!";
				oneDoor = true;
			}
		} 

		else 
		{
			doors.GetComponent<Text> ().text = "You locked everything.";
			lockedEverything = true;
		}
		//what was up with all that scratching?
		//for now... absolutely nothing


		//what are the consequences to having left some doors open?
		if (!lockedEverything && oneDoor) 
		{
			consequences.GetComponent<Text> ().text = "The door you left open happened to contain a shiny red button. " +
			"Because of your oversight, an intruder was able to press it, and trigger terrible things.";
		}
		else if (!lockedEverything && !oneDoor) 
		{
			consequences.GetComponent<Text> ().text = "One of the doors you left open happened to contain a " +
			"disgruntled inmate. Thanks to your oversight, there are now razor blades hidden inside every " +
			"food item in every fridge.";
		}
		else 
		{
			consequences.GetComponent<Text>().text = "Did you even check? You locked the public washroom! Where did you" +
				"expect people to go?";
		}

	}
}
