using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour {

	public GameObject Key;
	public string KeyValue;
	
	private float	speed;

	void Start () {
		speed = Random.Range( 0.1f, 0.2f );
	}
	
	void Update () {
		Key.transform.Translate(Vector3.down * speed);
		if (Input.GetKeyDown(KeyValue)){

            float Precision = Key.transform.localPosition.y + 4.0f;

            Debug.Log("Precision : "+(Precision));
            Destroy(Key);
        }

        if (Key.transform.localPosition.y < -5){
            Destroy(Key);
        }
	}
}
