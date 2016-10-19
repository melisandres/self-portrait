using UnityEngine;
using System.Collections;

public class input_controller : MonoBehaviour 
{
	public GameObject controllerUI;

	void Update () 
	{
		  if (Input.GetKey (KeyCode.D))
		{
			gameObject.GetComponent<player_movement> ().MoveHorizontal(1);
		}

		if (Input.GetKey (KeyCode.A))
		{
			gameObject.GetComponent<player_movement> ().MoveHorizontal(-1);
		}
			
		if (Input.GetKey (KeyCode.W))
		{
			gameObject.GetComponent<player_movement> ().MoveVertical(1);
		}
			
		if (Input.GetKey (KeyCode.S))
		{
			gameObject.GetComponent<player_movement> ().MoveVertical(-1);
		}

		if (Input.GetKeyDown (KeyCode.K)) 
		{
			gameObject.GetComponent<use_keys> ().TryToLock ();
		}

		if (Input.GetKeyUp (KeyCode.Space)) 
		{
			if (controllerUI.GetComponent<load_new_screen> ().canSwitchScreens == true) 
			{
				controllerUI.GetComponent<load_new_screen> ().LoadNextScreen ();
			}
		}
	}
}
