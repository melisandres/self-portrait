using UnityEngine;
using System.Collections;

public class use_keys : MonoBehaviour 
{
	public GameObject myDoor;

	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.tag == "Door") 
		{
			myDoor = other.gameObject;
		}
	}

	void OnCollisionExit(Collision other)
	{
		if (other.gameObject.tag == "Door")
		{
			myDoor = null;
		}
	}

	public void TryToLock()
	{
		if (myDoor == null)
			return;
		
		if (myDoor.GetComponent<door_script> ().difficultLock > 1) 
		{
			myDoor.GetComponent<door_script> ().difficultLock--;
			//play a random trying-to-lock sound from an array
		} 
		else if (myDoor.GetComponent<door_script> ().difficultLock == 1) 
		{
			myDoor.GetComponent<door_script> ().difficultLock--;
			myDoor.GetComponent<door_script> ().locked = 0;
			myDoor.GetComponent<door_script>().ResetMaterial();
			//play the LOCKING sound
		}
		else if (myDoor.GetComponent<door_script> ().difficultLock == 0) 
			return;
			
	}
}
