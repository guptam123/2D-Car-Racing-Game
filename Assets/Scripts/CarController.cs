using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour {

    public float carSpeed;
    public float maxPos = 1.18f;
    Vector3 position;
    public uiManager ui;

    void Awake()
    {

    }
	// Use this for initialization
	void Start () {
        
        position = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        position.x += Input.GetAxis("Horizontal") * carSpeed * Time.deltaTime;
        position.x = Mathf.Clamp(position.x, -1.18f, 1.18f);
        transform.position = position;
	}

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag=="Enemy Car")
        {
            Destroy(gameObject);
            ui.gameOver();
        }
    }
}
