using UnityEngine;
using System.Collections;

public class look_at : MonoBehaviour 
{
	public GameObject target;
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		gameObject.transform.LookAt (target.transform);
	}
}
