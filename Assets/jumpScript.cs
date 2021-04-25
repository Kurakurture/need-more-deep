using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpScript : MonoBehaviour
{
    public float minJumpMultipier = 1f;
    public float fallMultipier = 2f;

    public float jumpStrenght = 10;

    public bool inAir;

    [SerializeField] private Rigidbody rb;

    void Update()
    {
        if (rb.velocity.y > 0.3 || rb.velocity.y < -0.1)
        {
            inAir = true;
        }
        else { inAir = false; }

        if (Input.GetKeyDown("w") && rb.velocity.y < jumpStrenght && !inAir)
        {
            rb.velocity = Vector3.up * jumpStrenght;
        }

        if (rb.velocity.y < 0)
        {
            rb.velocity += Vector3.up * Physics.gravity.y * (fallMultipier - 1) * Time.deltaTime;
        }
        else if (rb.velocity.y > 0 && !Input.GetKey("w"))
        {
            rb.velocity += Vector3.up * Physics.gravity.y * (minJumpMultipier - 1) * Time.deltaTime;
        }
    }
}
