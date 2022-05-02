using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chompScript : MonoBehaviour
{
    private Chomp theChomp = new Chomp("Blake"); 
    private Rigidbody rb;
    public float speed = 20f;

    // Start is called before the first frame update
    void Start()
    {
        CORE.setChomp(theChomp);
        rb = this.gameObject.GetComponent<Rigidbody>();
    }



    // Update is called once per frame
    void Update()
    {
        //print(thePlayer.getName());
        if (Input.GetKeyDown("up"))
        {
            rb.velocity = Vector3.forward * speed;
        }
        else if (Input.GetKeyDown("down"))
        {
            rb.velocity = Vector3.back * speed;
        }
        else if (Input.GetKeyDown("left"))
        {
            rb.velocity = Vector3.left * speed;
        }
        else if (Input.GetKeyDown("right"))
        {
            rb.velocity = Vector3.right * speed;
        }
        else if (Input.GetKeyDown("space"))
        {
            rb.velocity = Vector3.up * speed;
        }
        else if (Input.GetKeyDown("f"))
        {
            print("fire");
        }
    }
