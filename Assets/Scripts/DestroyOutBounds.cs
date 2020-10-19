using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutBounds : MonoBehaviour
{
    private float topbound = 35.0f;
    private float lowbound = -15.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topbound)
        {
            Destroy(gameObject);
        }

        else if (transform.position.z < lowbound)
        {
            Debug.Log("Game Over");
            Destroy(gameObject);
        }
    }
}
