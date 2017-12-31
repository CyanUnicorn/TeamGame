using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour {
    public float fadeintime;
    private Image fadepanel;
    private Color currentColor= Color.black;
    // Use this for initialization
    void Start () {
        fadepanel = GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.timeSinceLevelLoad<fadeintime)
        {
            float alphachange = Time.deltaTime / fadeintime;
            currentColor.a -= alphachange;
            fadepanel.color = currentColor;
        }
        else
        {
            gameObject.SetActive(false);
        }
	}
}
