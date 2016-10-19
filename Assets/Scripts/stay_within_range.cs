using UnityEngine;
using System.Collections;

public class stay_within_range : MonoBehaviour 
{
	public GameObject target;
	public float range;


	void Update () 
	{
		if ((target.transform.position - gameObject.transform.position).magnitude > range) 
		{
			gameObject.transform.position = target.transform.position + ((target.transform.position - gameObject.transform.position).normalized * range);
		}
	}
}
