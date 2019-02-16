using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BlockType
{
	Normal,Jump,Empty
}
public class Block : MonoBehaviour
{

	public BlockType thisBlockType = BlockType.Empty;
	
	
	void Update () 
	{
		
	}

	private void OnCollisionEnter(Collision col)
	{
		if(col.gameObject.CompareTag("Player"))
		{
			if (thisBlockType == BlockType.Jump)
			{
				col.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up*1600f);
			}

            
        }
	}

   
   
}
