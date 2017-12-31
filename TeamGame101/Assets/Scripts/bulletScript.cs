using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour {
    private static int counter = 0;
    public int speed = 99;

    internal static int Counter
    {
        get { return counter; }
        set { counter = value; }
    }
	// Use this for initialization
	void Start () {
        //Destroy(gameObject, 5);
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(speed * Time.deltaTime * Vector2.up);
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if ( collision.gameObject.tag.Equals("unbreakable"))
        {

           Destroy(gameObject);
        }
    }
}
