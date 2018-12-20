using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearMovingObstacle : MonoBehaviour {
    public Vector3 pos1;
    public Vector3 pos2;
    public bool startHere = true;
    public float speed = 1.0f;
	// Use this for initialization
	void Start ()
    {
		if(startHere)
        {
            pos1 = transform.position;
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.position = Vector3.Lerp(pos1, pos2, Mathf.PingPong(Time.time * speed, 1.0f));	
	}
}
