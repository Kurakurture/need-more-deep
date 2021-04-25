using UnityEngine;
using UnityEngine.Events;

public class heroMoveInput : MonoBehaviour
{
    public Rigidbody rb;

    public UnityEvent MoveToRightStart;
    public UnityEvent MoveToLefttStart;
    public UnityEvent DeepColision;
    public UnityEvent Dead;

    public float movingSpeed = 2;
    public UnityEvent Idle;

    private bool moving;
    [SerializeField] private Animator animator;

    public bool longFlight = false;

    void Update()
    {
        animator.SetBool("moving", moving);

        if (longFlight)
            return;

        if (Input.GetKey("a"))
        {
            rb.AddRelativeForce(Vector3.left * movingSpeed);
            //rb.velocity = Vector3.left * movingSpeed;
            MoveToLefttStart.Invoke();
            moving = true;
        }

        if (Input.GetKey("d"))
        {
            rb.AddRelativeForce(Vector3.right * movingSpeed);
            //rb.velocity = Vector3.right * movingSpeed;
            MoveToRightStart.Invoke();
            moving = true;
        }

        if (!Input.GetKey("d") && !Input.GetKey("a"))
        {
            moving = false;

            Idle.Invoke();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Finish")
        {
            DeepColision.Invoke();
            Destroy(other.gameObject);
        }

        if (other.tag == "DamageZone")
        {
            longFlight = true;
            Dead.Invoke();
            animator.SetBool("dead", longFlight);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (longFlight)
        {
            Dead.Invoke();
            animator.SetBool("dead", longFlight);
        }
    }

    public void LongFlight()
    {
        longFlight = true;
    }
}
