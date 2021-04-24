using UnityEngine;

public class objectRotateToObject : MonoBehaviour
{
    public GameObject observeObject;
    public Vector3 offset;
    
    void Update()
    {
        this.transform.position = new Vector3(this.transform.position.x + offset.x,observeObject.transform.position.y + offset.y,this.transform.position.z+offset.z);
        //this.transform.LookAt(observeObject.transform);
    }
}
