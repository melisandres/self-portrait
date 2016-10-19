using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class timer : MonoBehaviour 
{
	//script slightly altered from a tutorial (https://www.youtube.com/watch?v=VVZudrLh5EA)
	public float time, seconds, minutes;
	public Text counterText;
	//this has to be called from the Tutorial page...
	public bool gameHasStarted = false;


	void Update () 
	{
		if (gameHasStarted) 
		{
			time -= Time.deltaTime;

			minutes = (int)(time / 60);
			seconds = (int)(time % 60);

			if (time > 0) 
			{		
				counterText.text = minutes.ToString ("00") + ":" + seconds.ToString ("00"); 
			}
			else if (time <= 0) 
			{
				gameObject.GetComponent<end_manager> ().deathByTimer = true;
				gameObject.GetComponent<end_manager> ().PrintEnding ();
			}
		}
	}
}
