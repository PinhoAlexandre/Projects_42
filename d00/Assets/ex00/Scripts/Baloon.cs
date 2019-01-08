using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baloon : MonoBehaviour {

	public GameObject	baloon;
	private int			souffle;
	private float		plusdesouffle;
	private float 		scalingFactor = 1f;

	// Use this for initialization
	void Start () {
		souffle = 50;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space) && souffle > 0){
			baloon.transform.localScale += new Vector3(0.7F, 0.7F, 0);
			souffle -= 10;
			if (souffle <= 0){
				plusdesouffle = Time.time;
			}
		}
		if (plusdesouffle > 0 && Time.time - 3 >= plusdesouffle){
			souffle = 50;
			plusdesouffle = 0;
		}
		if (souffle < 50 && plusdesouffle == 0){
			souffle++;
		}
		if ((baloon.transform.localScale.x < 5 && baloon.transform.localScale.y < 5) && (baloon.transform.localScale.x >= 0.1 && baloon.transform.localScale.y >= 0.1)) {
			baloon.transform.localScale = new Vector3(baloon.transform.localScale.x - baloon.transform.localScale.x * scalingFactor * Time.deltaTime, baloon.transform.localScale.y - baloon.transform.localScale.y * scalingFactor * Time.deltaTime);
		}
		else {
			GameObject.Destroy(baloon);
			Debug.Log("Balloon life time : " + Mathf.RoundToInt(Time.time) + "s");
		}

	}
}
