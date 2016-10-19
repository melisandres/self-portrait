using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class doors_list_controller : MonoBehaviour 
{
	
	//make a list of doors here
	public GameObject door;
	public GameObject[] doors;

	//how many doors are still locked in the whole game?
	public int doorsLocked;
	public int doorsUnlocked;


	void Start ()
	{
		doors = GameObject.FindGameObjectsWithTag("Door"); 
	}


	void Update() 
	{
		doorsUnlocked = 0;
		doorsLocked = 0;

		foreach (GameObject door in doors) 
		{ 
			if (door.GetComponent<door_script> ().locked == 1) 
			{
				doorsUnlocked++;	
			} 
			else 
			{
				doorsLocked++;
			}
		}
	}

}


