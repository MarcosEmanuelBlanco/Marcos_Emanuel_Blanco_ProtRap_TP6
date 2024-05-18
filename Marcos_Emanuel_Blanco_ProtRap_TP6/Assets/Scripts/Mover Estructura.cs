using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverEstructura : MonoBehaviour
{
    private float rotarX;
    private float rotarY;
    private float rotarZ;
    // Start is called before the first frame update
    void Start()
    {
        rotarX = 0;
        rotarY = 0;
        rotarZ = 0;
    }

    private void EjecutarRotacion()
    {
        if (Input.GetAxis("Horizontal") < 0)
        {
            ComenzarRotacionIzquierdaEjeY();
        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            ComenzarRotacionDerechaEjeY();
        }
        if (Input.GetAxis("Vertical") < 0)
        {
            ComenzarRotacionIzquierdaEjeX();
        }
        if (Input.GetAxis("Vertical") > 0)
        {
            ComenzarRotacionDerechaEjeX();
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            ComenzarRotacionIzquierdaEjeZ();
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            ComenzarRotacionDerechaEjeZ();
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            DetenerRotacion();
        }
    }
    private void ComenzarRotacionIzquierdaEjeY()
    {
        rotarY = 0;
        CancelInvoke(nameof(RotarIzquierdaEjeX));
        CancelInvoke(nameof(RotarDerechaEjeX));
        CancelInvoke(nameof(RotarIzquierdaEjeZ));
        CancelInvoke(nameof(RotarDerechaEjeZ));
        CancelInvoke(nameof(RotarDerechaEjeY));
        InvokeRepeating(nameof(RotarIzquierdaEjeY), 0, 0.1f);
    }
    private void ComenzarRotacionDerechaEjeY()
    {
        rotarY = 0;
        CancelInvoke(nameof(RotarIzquierdaEjeX));
        CancelInvoke(nameof(RotarDerechaEjeX));
        CancelInvoke(nameof(RotarIzquierdaEjeZ));
        CancelInvoke(nameof(RotarDerechaEjeZ));
        CancelInvoke(nameof(RotarIzquierdaEjeY));
        InvokeRepeating(nameof(RotarDerechaEjeY), 0, 0.1f);
    }
    private void RotarIzquierdaEjeY()
    {
        rotarY = -0.05f;
        transform.Rotate(0, rotarY, 0);
    }
    private void RotarDerechaEjeY()
    {
        rotarY = 0.05f;
        transform.Rotate(0, rotarY, 0);
    }
    private void ComenzarRotacionIzquierdaEjeX()
    {
        rotarX = 0;
        CancelInvoke(nameof(RotarIzquierdaEjeY));
        CancelInvoke(nameof(RotarDerechaEjeY));
        CancelInvoke(nameof(RotarIzquierdaEjeZ));
        CancelInvoke(nameof(RotarDerechaEjeZ));
        CancelInvoke(nameof(RotarDerechaEjeX));
        InvokeRepeating(nameof(RotarIzquierdaEjeX), 0, 0.1f);
    }
    private void ComenzarRotacionDerechaEjeX()
    {
        rotarX = 0;
        CancelInvoke(nameof(RotarIzquierdaEjeY));
        CancelInvoke(nameof(RotarDerechaEjeY));
        CancelInvoke(nameof(RotarIzquierdaEjeZ));
        CancelInvoke(nameof(RotarDerechaEjeZ));
        CancelInvoke(nameof(RotarIzquierdaEjeX));
        InvokeRepeating(nameof(RotarDerechaEjeX), 0, 0.1f);
    }
    private void RotarIzquierdaEjeX()
    {
        rotarX = -0.05f;
        transform.Rotate(rotarX, 0, 0);
    }
    private void RotarDerechaEjeX()
    {
        rotarX = 0.05f;
        transform.Rotate(rotarX, 0, 0);
    }
    private void ComenzarRotacionIzquierdaEjeZ()
    {
        rotarZ = 0;
        CancelInvoke(nameof(RotarIzquierdaEjeX));
        CancelInvoke(nameof(RotarDerechaEjeX));
        CancelInvoke(nameof(RotarIzquierdaEjeY));
        CancelInvoke(nameof(RotarDerechaEjeY));
        CancelInvoke(nameof(RotarDerechaEjeZ));
        InvokeRepeating(nameof(RotarIzquierdaEjeZ), 0, 0.1f);
    }
    private void ComenzarRotacionDerechaEjeZ()
    {
        rotarZ = 0;
        CancelInvoke(nameof(RotarIzquierdaEjeX));
        CancelInvoke(nameof(RotarDerechaEjeX));
        CancelInvoke(nameof(RotarIzquierdaEjeY));
        CancelInvoke(nameof(RotarDerechaEjeY));
        CancelInvoke(nameof(RotarIzquierdaEjeZ));
        InvokeRepeating(nameof(RotarDerechaEjeZ), 0, 0.1f);
    }
    private void RotarIzquierdaEjeZ()
    {
        rotarZ = -2.5f;
        transform.Rotate(0, 0, rotarZ);
    }
    private void RotarDerechaEjeZ()
    {
        rotarZ = 2.5f;
        transform.Rotate(0, 0, rotarZ);
    }
    private void DetenerRotacion()
    {
        rotarX = 0;
        rotarY = 0;
        rotarZ = 0;
        CancelInvoke(nameof(RotarIzquierdaEjeX));
        CancelInvoke(nameof(RotarDerechaEjeX));
        CancelInvoke(nameof(RotarIzquierdaEjeY));
        CancelInvoke(nameof(RotarDerechaEjeY));
        CancelInvoke(nameof(RotarIzquierdaEjeZ));
        CancelInvoke(nameof(RotarDerechaEjeZ));
        transform.Rotate(rotarX, rotarY, rotarZ);
    }

    // Update is called once per frame
    void Update()
    {
        EjecutarRotacion();
    }
}
