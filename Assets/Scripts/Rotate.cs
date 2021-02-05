using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    void Start()
    {
        transform.rotation = Random.rotation;
    }

    void Update()
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);

        float y = .75f + (Mathf.Sin(Time.time) / 3);
        transform.position = new Vector3(transform.position.x, y, transform.position.z);
    }
}


