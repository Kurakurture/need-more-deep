using UnityEngine;
using UnityEngine.Events;

public class heroMoveInput : MonoBehaviour
{
    public Rigidbody rb;

    public UnityEvent MoveToRightStart;
    public UnityEvent MoveToLefttStart;
    public UnityEvent DeepColision;
    public UnityEvent Dead;

    public bool longFlight = false;

    void FixedUpdate()
    {
        if(longFlight)
        return;

        if (Input.GetKey("a"))
        {
            MoveToLefttStart.Invoke();
        }

        if (Input.GetKey("d"))
        {
            MoveToRightStart.Invoke();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(longFlight)
        return;
        
        if (other.tag == "Finish")
        {
            DeepColision.Invoke();
            Destroy(other.gameObject);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (longFlight)
        {
            Dead.Invoke();
        }
    }

    public void LongFlight()
    {
        longFlight = true;
    }
}
