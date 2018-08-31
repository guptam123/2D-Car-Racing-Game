﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour {

    public GameObject[] cars;
    int carNo;
    public float maxPos = 1.25f;
    public float delayTimer = 0.5f;
    float timer;

	// Use this for initialization
	void Start () {
        timer = delayTimer;
	}
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;
        if(timer<=0)
        {
            Vector3 carPos = new Vector3(Random.Range(-1.25f, 1.25f), transform.position.y, transform.position.z);
            carNo = Random.Range(0, 5);
            Instantiate(cars[carNo], carPos, transform.rotation);
            timer = delayTimer;
        }
        

    }
}
