using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Club : MonoBehaviour {

    public GameObject club;
    public GameObject ball;
    public GameObject hole;
    
	private UnityEngine.Vector3 OGClubPos;
    private bool ready;
    private float speed = 0;

    void Start () {
        OGClubPos = club.transform.localPosition;
    }
    
    void Update () {
		if (ball.transform.localPosition.z != 3){
			if (Input.GetKey("space") && ready == true){
				if (ball.transform.localPosition.y > hole.transform.localPosition.y){
					club.transform.Translate(Vector3.up * 0.1f);
				}
				else {
					club.transform.Translate(Vector3.down * 0.1f);
				}
				speed = Mathf.Clamp(speed + 0.05f, 0.0f, 2.0f) ;
				
			}
			else if (speed <= 0){
				ready = true;
				if (ball.transform.localPosition.y > hole.transform.localPosition.y){
					club.transform.localPosition = new Vector3(ball.transform.localPosition.x - 0.25f, ball.transform.localPosition.y + 2, ball.transform.localPosition.z);
				}
				else {
					club.transform.localPosition = new Vector3(ball.transform.localPosition.x - 0.25f, ball.transform.localPosition.y - 1, ball.transform.localPosition.z);
				}
				OGClubPos = club.transform.localPosition;
			}
			else if(speed > 0){
				ready = false;
				speed -= 0.02f;
				club.transform.localPosition = OGClubPos;
			}
		}
    }
}
