using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIScript : MonoBehaviour
{
	public RectTransform earthTr;
	public Transform playerTr;
	public Transform startTr;
	public Transform endTr;
	private int startz;
	private int endz;
	private int non;
	
	private int posIdx;

	private void Start()
	{
		startz = (int)startTr.position.z;
		endz = (int)endTr.position.z;
		non = endz - startz;
		
		

	}

	// Update is called once per frame
	void Update ()
	{
		
		earthTr.anchoredPosition = new Vector3(playerTr.position.z*1000/non,0f,0f); 
	}
}
