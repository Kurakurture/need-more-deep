using UnityEngine;

public class cameraRotateToObject : MonoBehaviour
{
    public GameObject observeObject;
    public float speed;
    public Vector3 offset;
    
    void Update()
    {

        Vector3 vec = new Vector3(0,observeObject.transform.position.y + offset.y,0);

        this.transform.position = Vector3.Lerp(this.transform.position, vec, speed);
        this.transform.LookAt(observeObject.transform);
    }
}
