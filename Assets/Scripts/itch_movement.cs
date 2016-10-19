using UnityEngine;
using System.Collections;

public class itch_movement : MonoBehaviour 
{
	public float itchSpeed = 3;
	public GameObject uiController;

	public GameObject myItchPanel;

	public float initialItchDelay;
	public float itchDelay;
	public bool delaying;
	public bool hasRestarted;

	public GameObject startPosition;

	//I'm pretty sure that something here isn't properly resetting the itchDelay (or itchSpeed?)

	// we move back and forth from itch panel to itch movement, 
	void Update () 
	{
		if (uiController.GetComponent<itch_panel> ().itchy == true && !delaying && uiController.GetComponent<timer>().gameHasStarted == true) 
		{
			gameObject.transform.Translate (new Vector3 (-0.1f, 0f, 0f) * itchSpeed * itchDelay);
		} 
	}


	void OnCollisionEnter (Collision other)
	{
		if (other.gameObject.tag == "scratch") 
		{
			gameObject.GetComponent<scratch_yourself>().ScratchYourself ();
		}
	}


	public void DelayTheItch()
	{
		//delaying and hasRestarted seem to be doing nothing?
		delaying = true;
			
		gameObject.transform.position = startPosition.transform.position;
		hasRestarted = true;
		hasRestarted = false;
		itchDelay = itchDelay + 0.4f;
		delaying = false;
	
	}

}
