using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float speed = 4;

    //for movement
    private Vector3 pos;
    private Vector3 pos2;

    public int count = 0;
    public GameObject bulletPrefab;
    public Transform bulletSpawn;

    private Rigidbody rb;
    private Transform vrCamera;
    public Camera cam;

    public Transform gunEnd;
    public float weaponRange = 50f;
    public GameObject gun;
    public GameObject aim;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        vrCamera = Camera.main.transform;

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        movePlayer();
        //Vector3 rayOrigin = cam.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0.0f));


        //마우스 클릭하면 총알이 발사된다
        if (Input.GetButtonDown("Fire1"))
        {
            Fire();
        }

    }

    //player가 보고 있는 시선 방향에 따라 움직인다
    public void movePlayer()
    {
        Vector3 movement = speed * new Vector3(vrCamera.TransformDirection(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical")).x, 0f, vrCamera.TransformDirection(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical")).z);
        //Vector3 movement = speed * new Vector3(-vrCamera.InverseTransformDirection(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical")).z, 0f, -vrCamera.InverseTransformDirection(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical")).x);
        movement.y = rb.velocity.y;
        rb.velocity = movement;
        Vector3 rayOrigin = cam.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0.0f));
    }

    public void Fire()
    {
        // Create the Bullet from the Bullet Prefab
        var bullet = (GameObject)Instantiate(
            bulletPrefab,
            bulletSpawn.position,
            bulletSpawn.rotation);
        //Vector3 aimSpot = cam.transform.position;
        //aimSpot += cam.transform.forward * 50.0f;
        //bullet.transform.position = new Vector3(transform.position.x,transform.position.y+0.45f,transform.position.z) + Camera.main.transform.forward;
        //gunEnd.transform.LookAt(cam.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0)));
        gun.transform.LookAt(aim.transform.position);
        bullet.transform.position = gunEnd.transform.position;
        //bullet.transform.LookAt(cam.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, cam.nearClipPlane)));
        //bullet.transform.LookAt(aimSpot);
        bullet.GetComponent<Rigidbody>().velocity = Camera.main.transform.forward * 10;
        // Add velocity to the bullet
        //bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 4;
        //bullet.GetComponent<Rigidbody>().AddForce(transform.up * 10);

        // Destroy the bullet after 2 seconds
        Destroy(bullet, 2.0f);
    }
}
