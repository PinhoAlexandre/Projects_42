using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    public GameObject club;
    public GameObject ball;
    public GameObject hole;
    private bool ready = true;
    private float speed;
    private bool up = true;
    private int score = -15;

    void Update () {

        if (Input.GetKey("space") && ball.transform.localPosition.z != 3 && ready == true){
            speed = Mathf.Clamp(speed + 0.05f, 0.0f, 2.0f) ;
            if (ball.transform.localPosition.y > hole.transform.localPosition.y){
                up = false;
            }
            else {
                up = true;
            }
        }
        else if (ball.transform.localPosition.z != 3 && speed > 0) {
            ready = false;
            
            speed -= 0.02f;

            if (up == true){
                ball.transform.Translate(Vector3.up * Mathf.Clamp(speed , 0.0f, 2f));
            }
            else if (up == false){
                ball.transform.Translate(Vector3.down * Mathf.Clamp(speed , 0.0f, 2f));
            }
            if ( ball.transform.localPosition.y >= 7.5f ){
                up = false;
            }
            else if ( ball.transform.localPosition.y <= -7.5f ) {
                up = true;
            }

            if (speed <= 0.0000000000001f && ball.transform.localPosition.y + 0.5f >= hole.transform.localPosition.y && ball.transform.localPosition.y - 0.5f <= hole.transform.localPosition.y){
                Debug.Log("Score: "+score);
                ball.transform.localPosition = new Vector3 (ball.transform.localPosition.x, ball.transform.localPosition.y, 3);
            }
        }
        else if (speed <= 0 && ready == false){
            if (ball.transform.localPosition.z != 3){
                score = score+5;
                Debug.Log("Score: "+score);
            }
            
            ready = true;
        }
    }
}