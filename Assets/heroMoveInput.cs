using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class heroMoveInput : MonoBehaviour
{
    public GameObject referencedPotitionObject;
    public Rigidbody rb;
    public int maxVectorForceX;
    public int minVectorForceX;

    public UnityEvent JumpStart;
    public UnityEvent MoveToRightStart;
    public UnityEvent MoveToLefttStart;

    public Vector3 velocity;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //if(rb.velocity.x > maxVectorForceX){rb.velocity = new Vector3(maxVectorForceX,rb.velocity.y,rb.velocity.z);}
        //if(rb.velocity.x < minVectorForceX){rb.velocity = new Vector3(minVectorForceX,rb.velocity.y,rb.velocity.z);}
        //if(rb.velocity.z != 0 ){rb.velocity = new Vector3(rb.velocity.x,rb.velocity.y,0);}

        //velocity = rb.velocity;

        //gameObject.transform.LookAt(referencedPotitionObject.transform);

        if (Input.GetKey("a"))
        {
            MoveToLefttStart.Invoke();
        }

        if (Input.GetKey("d"))
        {
            MoveToRightStart.Invoke();
        }

        if (Input.GetKeyDown("w"))
        {
            JumpStart.Invoke();
        }
    }
}
