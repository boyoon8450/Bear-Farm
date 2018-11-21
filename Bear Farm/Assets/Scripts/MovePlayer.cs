using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float speed = 4;

    //for movement
    private Vector3 pos;
    private Vector3 pos2;

    private Rigidbody rb;
    private Transform vrCamera;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        vrCamera = Camera.main.transform;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Vector3 movement= speed * new Vector3(vrCamera.TransformDirection(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical")).x, 0f, vrCamera.TransformDirection(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical")).z);
        //movement.y = rb.velocity.y;
        //rb.velocity = movement;

        //pos = transform.position;
            movePlayer();

    }

    public void movePlayer()
    {
        Vector3 movement = speed * new Vector3(vrCamera.TransformDirection(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical")).x, 0f, vrCamera.TransformDirection(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical")).z);
        //Vector3 movement = speed * new Vector3(-vrCamera.InverseTransformDirection(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical")).z, 0f, -vrCamera.InverseTransformDirection(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical")).x);
        movement.y = rb.velocity.y;
        rb.velocity = movement;
    }
}
