using UnityEngine;
using UnityEngine.Events;

public class jumpScript : MonoBehaviour
{
    public float minJumpMultipier = 1f;
    public float fallMultipier = 2f;

    public float jumpStrenght = 10;
    public float timeOfFlight;
    public float timeOfFlightToDead;

    public UnityEvent FlightWasLong;

    public bool inAir;

    [SerializeField] private Rigidbody rb;
    [SerializeField] private Animator animator;

    void Update()
    {
        animator.SetBool("inAir", inAir);

        if (rb.velocity.y > 0.3 || rb.velocity.y < -0.1)
        {
            inAir = true;
            timeOfFlight += Time.deltaTime;
        }
        else
        {
            inAir = false;
            timeOfFlight = 0;
        }

        if (timeOfFlight >= timeOfFlightToDead)
        {
            // FlightWasLong.Invoke();
        }

        if (Input.GetKeyDown("w") && !inAir)
        {
            rb.AddRelativeForce(Vector3.up * jumpStrenght);
            animator.SetTrigger("jump");
        }

        // if (Input.GetKey("a") && inAir)
        // {
        //     rb.AddRelativeForce(Vector3.left * jumpStrenght);
        // }

        // if (Input.GetKey("d") && inAir)
        // {
        //     rb.AddRelativeForce(Vector3.right * jumpStrenght);
        // }

        // if (rb.velocity.y < 0)
        // {
        //     rb.velocity += Vector3.up * Physics.gravity.y * (fallMultipier - 1) * Time.deltaTime;
        // }
        // else if (rb.velocity.y > 0 && !Input.GetKey("w"))
        // {
        //     rb.velocity += Vector3.up * Physics.gravity.y * (minJumpMultipier - 1) * Time.deltaTime;
        // }
    }
}
