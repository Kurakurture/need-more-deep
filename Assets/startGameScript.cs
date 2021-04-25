using UnityEngine;
using UnityEngine.Events;

public class startGameScript : MonoBehaviour
{
    public UnityEvent StartGame;

    void Update()
    {
        if (Input.GetKey("space"))
        {
            StartGame.Invoke();
        }
    }
}
