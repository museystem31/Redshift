﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBigAsteroid : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    void OnCollisionEnter(Collision col)
    {
        Debug.Log("Tag name:" + col.gameObject.tag);
        if (string.Equals(col.gameObject.tag, "oxygen") || string.Equals(col.gameObject.tag, "nitrogen") || string.Equals(col.gameObject.tag, "hydrogen") || string.Equals(col.gameObject.tag, "sulfur") || string.Equals(col.gameObject.tag, "carbon"))
        {
            AnimationManager.instance.hitBigAsteroid.Play();
            Debug.Log("asteroid hit the big asteroid collision happened");
            StartCoroutine(ClearBackendEffect());
        }
    }

    IEnumerator ClearBackendEffect()
    {
        yield return new WaitForSeconds(1.5f);
        AnimationManager.instance.hitBigAsteroid.Stop();
    }
}
