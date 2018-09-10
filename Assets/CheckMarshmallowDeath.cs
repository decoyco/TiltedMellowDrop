﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckMarshmallowDeath : MonoBehaviour {

    public int lives = 5;
    public StickToOther stick;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (lives <= 0)
            Debug.Log("GAME OVER");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //only "live" objects will trip this
        if (collision.gameObject.tag == "Sticky")
        {
            lives--;
            Destroy(collision.gameObject);
        }
    }
}