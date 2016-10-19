using UnityEngine;
using System.Collections;

public class freeze_y : MonoBehaviour 
{
	public float Y;

	void Update()
	{
		Vector3 temp = gameObject.transform.position;
		temp.y = Y;
	}
}
