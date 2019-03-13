using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActorRunMapTest : MonoBehaviour {

    CharacterController controller;
    Animation anima;
    Camera camera=null;
    float speed = 2.0f;
    Vector3 dir;
    void Start ()
    {
        controller = gameObject.GetComponent<CharacterController>();
        anima = gameObject.GetComponent<Animation>();
        camera = Camera.main;
        dir = gameObject.transform.position - camera.transform.position;
	}
	
	void Update ()
    {
        if (Input.GetKey(KeyCode.W))
        {
            controller.Move(Vector3.forward * Time.deltaTime * speed);
            anima.Play("Walk");
            transform.localEulerAngles = new Vector3(0, 0, 0);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            controller.Move(Vector3.forward * Time.deltaTime * -speed);
            anima.Play("Walk");
            transform.localEulerAngles = new Vector3(0, 180, 0);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            controller.Move(Vector3.right * Time.deltaTime * -speed);
            anima.Play("Walk");
            transform.localEulerAngles = new Vector3(0, -90, 0);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            controller.Move(Vector3.right * Time.deltaTime * speed);
            anima.Play("Walk");
            transform.localEulerAngles = new Vector3(0, 90, 0);
        }
        else
        {
            anima.Play("Idle");
        }
        if(Input.GetMouseButton(0))
        {
           
        }
        if(Input.GetMouseButton(1))
        {

        }
        if (!controller.isGrounded)
        {
            controller.Move(Vector3.down * 10.0f);
        }
        camera.transform.position = transform.position - dir;
    }
}
