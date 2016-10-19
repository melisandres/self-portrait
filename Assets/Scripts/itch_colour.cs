using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class itch_colour : MonoBehaviour 
{
	public Color lerpedColor;

	public Button itch;
	public Button scratch;

	public float maxDistance;
	public float currentDistance;

	//and now for the flashing record
	public Image recordLight;
	public Color flashing;


	void Start () 
	{
		maxDistance = (itch.transform.position - scratch.transform.position).magnitude;
	}
	

	void Update () 
	{
		itch.GetComponent<Image> ().color = lerpedColor;
		//scratch.GetComponent<Image> ().color = lerpedColor;

		currentDistance = (itch.transform.position - scratch.transform.position).magnitude;

		lerpedColor = Color.Lerp(Color.red, Color.white, (float)currentDistance / maxDistance);


//		recordLight.GetComponent<Image> ().color = flashing;
//		if (currentDistance < 80) 
//		{
//			flashing = Color.Lerp (Color.white, Color.black, Mathf.PingPong (Time.time, 0.6f));
//		}
//
//		else if (currentDistance > 80) 
//		{	
//			flashing = Color.white;
//		}

	}
}
