using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cam : MonoBehaviour
{
    public GameObject cameraobj;

	public GameObject player1;
	public GameObject player2;
	public GameObject player3;
    private bool win;

	//private Vector3 offset;
	private GameObject active_player;
	// Use this for initialization
	void Start () {
		active_player = player1;
        win = false;

    }
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey("1")){
			active_player = player1;
		}
		if (Input.GetKey("2")){
			active_player = player2;
		}
		if (Input.GetKey("3")){
			active_player = player3;
		}
		if (Input.GetKey("r")){
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
		cameraobj.transform.localPosition = new Vector3(active_player.transform.position.x, active_player.transform.position.y, -10);

        if (win == false && player1.GetComponent<playerScript_ex01>().triggerCount == 3 && player2.GetComponent<playerScript_ex01>().triggerCount == 3 && player3.GetComponent<playerScript_ex01>().triggerCount == 3)
        {
            Debug.Log("Level done !");
            if (SceneManager.GetActiveScene().buildIndex < SceneManager.sceneCount)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
            else
            {
                SceneManager.LoadScene(0);
            }
            
            win = true;
        }
    }

	void LateUpdate ()
    {
        // Set the position of the camera's transform to be the same as the player's, but offset by the calculated offset distance.
        //transform.position = active_player.transform.position + offset;
    }
}
