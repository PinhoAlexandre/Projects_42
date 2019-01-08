using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour {

    public     GameObject        pipe;
    public     GameObject        bird;
	private int 				score = 0;
	private bool				done = false;
    private float             speed;
    private bool left = true;
	private bool coli = false;

    // Use this for initialization
    void Start () {
        speed = 0.1f;
    }
    
    // Update is called once per frame
    void Update () {
        speed += 0.00001f;

	if ((bird.transform.localPosition.y > 1.2 || bird.transform.localPosition.y < -1.2) && pipe.transform.localPosition.x > -0.8 && pipe.transform.localPosition.x < 0.9 && pipe.transform.localPosition.z < 0){
				coli = true;
			}
        if (left == true && bird.transform.localPosition.y > -2.7 && coli == false){
            pipe.transform.Translate(Vector3.left * speed);
            pipe.transform.localPosition = new Vector3( pipe.transform.localPosition.x, pipe.transform.localPosition.y, -1);
            if ( pipe.transform.localPosition.x < -3.5 ) {
                left = false;
				score += 5;
            }
			
        }
        else if (bird.transform.localPosition.y < -2.7 || coli == true){
			if (done == false){
				Debug.Log("Score: "+score);
				Debug.Log("Time: "+Mathf.RoundToInt(Time.time));
				done = true;
			}
        }
        else {
            pipe.transform.Translate(Vector3.right * speed);
            pipe.transform.localPosition = new Vector3( pipe.transform.localPosition.x, pipe.transform.localPosition.y, 3);
            if ( pipe.transform.localPosition.x > 3.5 ) {
                left = true;
            }
        }


    }
}