using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PongBall : MonoBehaviour {

	public 	GameObject    	ball;
	public 	GameObject    	player1;
	public 	GameObject    	player2;
	private bool			dir_left;
	private bool			dir_up;
	private int				score1;
	private int				score2;

	// Use this for initialization
	void Start () {
		score1 = 0;
		score2 = 0;
		if (Random.Range(-10.0f, 10.0f) > 0){
			dir_left = true;
			dir_up = false;
		}
		else {
			dir_left = false;
			dir_up = true;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
		if (ball.transform.localPosition.y >= 4.95 && ball.transform.localPosition.y < 5){
			dir_up = false;
		}
		if (ball.transform.localPosition.y <= -4.95 && ball.transform.localPosition.y > -5){
			dir_up = true;
		}
		if (ball.transform.localPosition.x <= -10){
			ball.transform.localPosition = new Vector3( 0, 0, -1);
			score2++;
			Debug.Log("Player 1: "+score1+" | Player 2: "+score2);

		}
		if (ball.transform.localPosition.x >= 10){
			ball.transform.localPosition = new Vector3( 0, 0, -1);
			score1++;
			Debug.Log("Player 1: "+score1+" | Player 2: "+score2);
		}


		if (ball.transform.localPosition.x <= player1.transform.localPosition.x +0.5 
			&& ball.transform.localPosition.x >= player1.transform.localPosition.x -0.5
			&& ball.transform.localPosition.y <= player1.transform.localPosition.y + 1 
			&& ball.transform.localPosition.y >= player1.transform.localPosition.y - 1){
			dir_left = false;
			if (dir_up == true){
				dir_up = false;
			}
			else {
				dir_up = true;
			}
		}


		if (ball.transform.localPosition.x <= player2.transform.localPosition.x +0.5 
			&& ball.transform.localPosition.x >= player2.transform.localPosition.x -0.5
			&& ball.transform.localPosition.y <= player2.transform.localPosition.y + 1 
			&& ball.transform.localPosition.y >= player2.transform.localPosition.y - 1){
			dir_left = true;
			if (dir_up == true){
				dir_up = false;
			}
			else {
				dir_up = true;
			}
		}

		if (dir_left == true){
			ball.transform.Translate(Vector3.left * 0.2f);
		}
		else if (dir_left == false){
			ball.transform.Translate(Vector3.right * 0.2f);
		}
		if (dir_up == true){
			ball.transform.Translate(Vector3.up * 0.2f);
		}
		else if (dir_up == false){
			ball.transform.Translate(Vector3.down * 0.2f);
		}
	}
}
