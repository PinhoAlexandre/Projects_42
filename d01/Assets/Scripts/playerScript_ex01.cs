using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript_ex01 : MonoBehaviour
{

    public GameObject player;
    public int id;
    private float jumpVelocity = 7;
    private int current_id = 1;
    private bool canJump = false;
    private float multiplier = 1;
    public bool onTrigger;
    public int triggerCount = 0;
    private float fallMultiplier = 2.5f;
    private float lowFallMultiplier = 2f;
    public Transform TeleportGoal;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<Rigidbody2D>().velocity.y < 0)
        {
            GetComponent<Rigidbody2D>().velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
        }
        else if (GetComponent<Rigidbody2D>().velocity.y > 0 && !(Input.GetKey("space")))
        {
            GetComponent<Rigidbody2D>().velocity += Vector2.up * Physics2D.gravity.y * (lowFallMultiplier - 1) * Time.deltaTime;
        }

        if (Input.GetKey("1"))
        {
            current_id = 1;
            multiplier = 1;
        }
        if (Input.GetKey("2"))
        {
            current_id = 2;
            multiplier = 1.25f;
        }
        if (Input.GetKey("3"))
        {
            current_id = 3;
            multiplier = 1.5f;
        }
    }

    private void FixedUpdate()
    {
        if (onTrigger == true && triggerCount == 3)
        {
            onTrigger = false;
        }
        if (current_id == id)
        {
            GetComponent<Rigidbody2D>().mass = 1f * multiplier;
            if (Input.GetKey("space") && canJump)
            {
                GetComponent<Rigidbody2D>().velocity = Vector2.up * (jumpVelocity * multiplier);
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

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "teleport")
        {
            Debug.Log("plop");
            player.transform.position = TeleportGoal.position;
        }
        else
        {
            onTrigger = true;
            triggerCount++;
        }

    }

    void OnTriggerExit2D(Collider2D other)
    {
        onTrigger = false;
        triggerCount--;
    }

}
