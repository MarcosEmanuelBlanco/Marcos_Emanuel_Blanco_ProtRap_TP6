using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverDisco : MonoBehaviour
{
    private float movY;

    void Start()
    {
        movY = transform.position.y;
    }
    private void MoverY()
    {
        if (Input.GetKey(KeyCode.R))
        {
            movY += 0.01f;
            transform.position = new(transform.position.x, movY,transform.position.z);
        }

        if (Input.GetKey(KeyCode.F))
        {
            movY -= 0.01f;
            transform.position = new(transform.position.x, movY, transform.position.z);
        }
    }
    void Update()
    {
        MoverY();
    }
}
