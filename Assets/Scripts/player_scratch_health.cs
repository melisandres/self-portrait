using UnityEngine;
using System.Collections;

public class player_scratch_health : MonoBehaviour 
{
	public int scratchDamage = 0;
	public int maxScratchDamage = 5;
	public Color scratchedColour;
	Renderer rend;

	public GameObject itchButton;
	//get damage from <scratch_youself> which is on itchButton


	void Start()
	{
		rend = GetComponent<Renderer>();
		rend.material.color = scratchedColour;
	}

	void Update()
	{
		scratchDamage = itchButton.GetComponent<scratch_yourself> ().recordedScratch;
		scratchedColour = Color.Lerp(Color.white, Color.red, (float)scratchDamage / maxScratchDamage);
		rend.material.color = scratchedColour;
	}




}