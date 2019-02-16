using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{

	public Transform playerTr;
	private Vector3 offset;
	
	void Start ()
	{
		offset = playerTr.position - transform.position;
		
	}
	
	void LateUpdate ()
	{
		
		Vector3 pos = playerTr.position - offset;
		//pos.y = 5;
		transform.position = pos;
	}
}
