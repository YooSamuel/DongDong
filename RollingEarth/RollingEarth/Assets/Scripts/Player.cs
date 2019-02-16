using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
	private Rigidbody rb;
	public float power=10f;
	public float moveSpeed = 3f;
    public float turnSpeed = 50f;
    
	void Start ()
	{

        //rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0f, 0f, 0f);

    }

	void Update ()
    {
       

        if (Input.GetKeyDown(KeyCode.D))
        {
            //transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
            //transform.Rotate(0, 0, 1);
            //transform.Rotate(new Vector3(Time.deltaTime*0,0,1));
            //transform.Rotate(0, 0, moveSpeed/2);
            //transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
            transform.Rotate(0, 90, 0);





        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            //transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
            //transform.Rotate(0, 0, 1);
            //transform.Rotate(new Vector3(Time.deltaTime*0,0,1));
            //transform.Rotate(0, 0, moveSpeed/2);
            //transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
            transform.Rotate(0, -90, 0);


        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
            //transform.Rotate(0, 0, 1);
            //transform.Rotate(new Vector3(Time.deltaTime*0,0,1));
           // transform.Rotate(0, 0, moveSpeed / 2);
        }
        

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
            //transform.Rotate(0, 0, 1);
             //transform.Rotate(new Vector3(Time.deltaTime*0,0,1));
            //transform.Rotate(0, 0, moveSpeed/2);
        }

       
    }


    private void OnCollisionEnter(Collision col)
	{
        if(col.gameObject.CompareTag("Ground"))
        {
            SceneManager.LoadScene(1);
        }else if(col.gameObject.CompareTag("Ground2"))
        {
            SceneManager.LoadScene(2);
        }
        else if (col.gameObject.CompareTag("Ground3"))
        {
            SceneManager.LoadScene(3);
        }
        rb.velocity = new Vector3(0f,0f,15f);
		print(rb.velocity);

	}
   
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("EndPos"))
        {
            SceneManager.LoadScene(2);

        }
        else if (other.CompareTag("EndPos2"))
        {
            SceneManager.LoadScene(3);
        }
        else if(other.CompareTag("EndPos3"))
        {
            SceneManager.LoadScene(0);
        }
    }
}
