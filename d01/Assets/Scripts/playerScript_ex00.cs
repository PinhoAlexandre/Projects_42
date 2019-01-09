using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript_ex00 : MonoBehaviour {

	public GameObject player;
	public int id;
	private float jumpVelocity = 7;
	private int current_id = 1;
    private bool canJump = false;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey("1")){
			current_id = 1;
		}
		if (Input.GetKey("2")){
			current_id = 2;
		}
		if (Input.GetKey("3")){
			current_id = 3;
		}
	}

    private void FixedUpdate()
    {
        if (current_id == id)
        {
            GetComponent<Rigidbody2D>().mass = 1f;
            if (Input.GetKey("space") && canJump)
            {
                GetComponent<Rigidbody2D>().velocity = Vector2.up * jumpVelocity;
                canJump = false;
            }
            if (Input.GetKey("left"))
            {
                player.transform.Translate(Vector3.left * 0.1f);
            }
            if (Input.GetKey("right"))
            {
                player.transform.Translate(Vector3.right * 0.1f);
            }
        }
        else
        {
            GetComponent<Rigidbody2D>().mass = 500f;
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.enabled)
        {
            if (coll.contacts.Length > 0)
            {
                ContactPoint2D contact = coll.contacts[0];
                if (Vector2.Dot(contact.normal, Vector2.up) > 0.5)
                {
                    canJump = true;
                }
            }
        }
    }

}
