using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class updatetext : MonoBehaviour {
    private int dist;
	// Use this for initialization
	void Awake () {
        dist = 0;
	}
	
	// Update is called once per frame
	void Update () {

        GameObject.Find("GUIText").GetComponent<GUIText>().text = dist;
	}
}
