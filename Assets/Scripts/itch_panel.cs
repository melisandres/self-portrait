using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class itch_panel : MonoBehaviour 
{
	//variables for the slider speed and incrementation
	public GameObject myItchPanel;

	//public Button itch;
	public float delay;

	//variable for whether or not the itchPanel is active
	public float timer;
	public float timerLength;
	bool timerHasStarted;

	public bool itchy;
	public int numOfScratches =0;

	public GameObject itchButton;


	// Use this for initialization
	void Start () 
	{
		myItchPanel.SetActive (false);
	}
	

	void Update () 
	{
		//this will start a timer to enable the first itch
		if (!itchy && numOfScratches == 0 && gameObject.GetComponent<timer>().gameHasStarted == true ) 
		{
			timer += Time.deltaTime;
			if (timer >= timerLength) 
			{
				itchy = true;
				myItchPanel.SetActive (true);
				timer = 0;
				itchButton.GetComponent<itch_movement> ().itchDelay = itchButton.GetComponent<itch_movement> ().initialItchDelay;
			}
		}


		//this will start a timer to enable all subsequent itches
		if (!itchy && numOfScratches > 0 && gameObject.GetComponent<timer>().gameHasStarted == true ) 
		{
			if (!timerHasStarted) 
			{
				timerLength = Random.Range (10, 30);
				timerHasStarted = true;
			} 
			else if (timerHasStarted) 
			{
				timer += Time.deltaTime;
				if (timer >= timerLength) 
				{
					itchy = true;
					myItchPanel.SetActive (true);
					timer = 0;
					timerHasStarted = false;
					itchButton.GetComponent<itch_movement> ().itchDelay = itchButton.GetComponent<itch_movement> ().initialItchDelay;
				}
			}
		}
	}
}
