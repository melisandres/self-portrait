using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class door_script : MonoBehaviour 
{
	//this is to manage the state of each door individually
	//locked or unlocked, (or difficult to lock) as well as the materials reflecting this state

	public Material unknown, green, red;
	public Material[] lockedState;
	public int locked;
	Renderer rend;
	public int difficultLock;


	void Start()
	{
		rend = GetComponent<Renderer>();
		rend.material = unknown;
		lockedState = new Material[]{red, green};
		locked = 1;

		int unlucky = Random.Range (1, 10);

		if (unlucky > 8) 
		{
			difficultLock = Random.Range (1, 10);
		} 

		else if (unlucky <= 8 && unlucky >= 2) 
		{
			difficultLock = 1;
		} 

		else 
		{
			difficultLock = 0;
			locked = 0;
		}
	}

	void OnCollisionEnter(Collision other)
	{
		rend.material = lockedState[locked];
	}

	public void ResetMaterial ()
	{
		rend.material = lockedState[locked];
	}

	void OnCollisionExit (Collision other)
	{
		rend.material = unknown;
	}
		
}
