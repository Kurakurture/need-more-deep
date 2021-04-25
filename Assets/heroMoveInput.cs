using UnityEngine;
using UnityEngine.Events;

public class heroMoveInput : MonoBehaviour
{
    public Rigidbody rb;

    public UnityEvent MoveToRightStart;
    public UnityEvent MoveToLefttStart;

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
}
