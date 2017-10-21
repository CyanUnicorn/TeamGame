using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerup_spawn : MonoBehaviour {
    public GameObject[] powerup;
    public int arraymax;
    public int arraynum;
    public int triggervalue;
    public int randomValue;
    public int max;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        arraynum = Random.Range(0, arraymax);
        randomValue = Random.Range(0, max);
        if(triggervalue == randomValue)
        {
            Instantiate(powerup[arraynum], gameObject.transform);
        }
	}
}
