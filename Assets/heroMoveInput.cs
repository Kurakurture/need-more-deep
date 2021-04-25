using UnityEngine;
using UnityEngine.Events;

public class heroMoveInput : MonoBehaviour
{
    public Rigidbody rb;

    public UnityEvent MoveToRightStart;
    public UnityEvent MoveToLefttStart;
    public UnityEvent DeepColision;

    void FixedUpdate()
    {
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
        if (other.tag == "Finish")
        {
            DeepColision.Invoke();
        }
    }
}
