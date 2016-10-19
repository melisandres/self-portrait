using UnityEngine;
using System.Collections;

public class camera_raycast : MonoBehaviour 
{
	float minRange = 1;

	RaycastHit hit;
	public GameObject player;
	float distance;

	void FixedUpdate()
	{
		distance = Vector3.SqrMagnitude (gameObject.transform.position - player.transform.position);

		if (Mathf.Abs(distance) > minRange)
		{
			if(Physics.Raycast(transform.position, (player.transform.position - gameObject.transform.position), out hit, minRange))
			{
				if(hit.transform.tag == "Player")
				{
					Debug.Log ("camera can see the player");
				}
			}
		}
	}

		
}
