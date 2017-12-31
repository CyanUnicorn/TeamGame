using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {
    float hInput;
    float vInput;
    float fire;
    float sprintInput;

    Vector3 mouse;

    public GameObject bullet;
    public Transform bulletSpawn;
    public float bulletSpeed = 1.0f;
    public Rigidbody2D rb;


    float sprintSpeed = 10.0f;
   public float speed = 5.0f;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        
	}
	
	// Update is called once per frame
	void Update () {
        hInput = Input.GetAxis("Horizontal");
        vInput = Input.GetAxis("Vertical");
        fire = Input.GetAxis("Fire1");
        //sprintInput = Input.GetAxis("Sprint");


        //Ray ray = Camera.main.ScreenPointToRay(new Vector3(200, 200, 0));
        Vector3 diff = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        diff.Normalize();

        float rot_z = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rot_z - 90);

        if (Input.GetKey(KeyCode.LeftShift))
        {
         
            transform.Translate(new Vector2(hInput * sprintSpeed * Time.deltaTime, vInput * sprintSpeed * Time.deltaTime));
        }
        else
        {
        
            transform.Translate(new Vector2(hInput * speed * Time.deltaTime, vInput * speed * Time.deltaTime));
        }
        if (Input.GetKeyUp(KeyCode.F))
        {
            Fire();

        }
        
    }

    

    public void Fire()
    {
        GameObject spawnBullet = Instantiate(bullet, bulletSpawn.transform.position, Quaternion.identity);
       
        
    }

}
