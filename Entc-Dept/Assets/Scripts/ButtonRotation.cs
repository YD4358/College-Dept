using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonRotation : MonoBehaviour
{
    public bool I;
    public bool K;

    public void IT()
    {
        I = true;
    }

    public void IF()
    {
        I = false;
    }
    //--------------------------------------------------
    public void KT()
    {
        K = true;
    }

    public void KF()
    {
        K = false;
    }
    //--------------------------------------------------
   
    void Update()
    {
        if (I)
        {
            Debug.Log("I Pressed");
            transform.Rotate(-1, 0, 0, Space.Self);
        }

        if (K)
        {
            Debug.Log("K Pressed");
            transform.Rotate(1, 0, 0, Space.Self);
        }
    }
}
