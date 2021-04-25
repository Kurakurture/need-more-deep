using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelChanger : MonoBehaviour
{

    private void Awake() {
        transform.rotation = Quaternion.Euler(transform.rotation.x, Random.rotation.y,transform.rotation.z);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
