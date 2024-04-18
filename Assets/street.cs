using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class street : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Camera.main.transform.position.z >= (this.transform.position.z + 20))
        {
            this.transform.position += new Vector3(0, 0, 60);
        }

    }
}
