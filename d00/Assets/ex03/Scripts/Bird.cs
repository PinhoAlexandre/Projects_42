using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour {

    public     GameObject        bird;
    public     GameObject        pipe;
    private bool coli = false;

    // Use this for initialization
    void Start () {
        
    }
    
    // Update is called once per frame
    void Update () {
		if ((bird.transform.localPosition.y > 1.2 || bird.transform.localPosition.y < -1.2) && pipe.transform.localPosition.x > -0.8 && pipe.transform.localPosition.x < 0.9 && pipe.transform.localPosition.z < 0){
				coli = true;
			}
        if ( Input.GetKeyDown("space") && coli == false){
            bird.transform.Translate(Vector3.up * 1.5f);
        }
        else if (coli == true){
            ;
        }
        else {
            bird.transform.Translate(Vector3.down * 0.07f);
        }
        if (bird.transform.localPosition.y < -2.7){
            coli = true;
        }
    }
}
