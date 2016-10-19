using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class slider_script : MonoBehaviour 
{
	//variables for the slider speed and incrementation
	public Slider mySlider;
	public GameObject mySliderPanel;
	public float delay;
	public float avoid = 0.1f;
	public float avoidIncrease = 0.1f;
	public bool doOnce = false;

	//variable for whether or not the slider is active
	public bool isItchy;
	public float timer;
	public float timerLength;
	public int numOfScratches;
	bool timerHasStarted;

	void Start()
	{
		mySliderPanel.SetActive (false);
		//mySlider.enabled = false;
	}

	//this controls the speed of the slider and the incrementation of that speed through 
	//the user pulling the slider to the right.
	void Update ()
	{
		//this will start a timer to enable the first itch
		if (!isItchy && numOfScratches == 0) 
		{
			timer += Time.deltaTime;
			if (timer >= timerLength) 
			{
				isItchy = true;
				mySliderPanel.SetActive (true);
				//mySlider.enabled = true;
				timer = 0;
			}
		}


		//this will start a timer to enable all subsequent itches
		if (!isItchy && numOfScratches > 0) 
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
					isItchy = true;
					mySliderPanel.SetActive (true);
					//mySlider.enabled = true;
					timer = 0;
					timerHasStarted = false;
				}
			}
		}



		//this controls the itch slider speed as it interacts with player input
		if (isItchy) 
		{	
			mySlider.value -= Time.deltaTime / delay * avoid;

			if (mySlider.value > 0.96f && !doOnce) 
			{
				avoid = avoid + avoidIncrease;
				doOnce = true;
			} 
			else 
			{
				doOnce = false;
			}

			if (mySlider.value == 0) 
			{
				avoid = 0.1f;
				mySlider.value = 1;
				mySliderPanel.SetActive (false);
				numOfScratches++;
				doOnce = false;
				isItchy = false;

				//check if security camera collision
			}
		}
	}
}
