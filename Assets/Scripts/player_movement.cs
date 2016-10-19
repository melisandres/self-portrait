using UnityEngine;
using System.Collections;

public class player_movement : MonoBehaviour 
{
	public float accelForce = 1000f;

	//Move side to side
	public void MoveHorizontal(int numDir)
	{
		Vector3 direction = new Vector3 ();
		direction.x = numDir;
		direction = direction.normalized;
		gameObject.GetComponent<Rigidbody> ().AddForce (direction* accelForce * Time.deltaTime);
	}
		
	public void MoveVertical (int numDir)
	{
		Vector3 direction = new Vector3 ();
		direction.z = numDir;
		direction = direction.normalized;
		gameObject.GetComponent<Rigidbody> ().AddForce (direction* accelForce * Time.deltaTime);
	}
		
}
