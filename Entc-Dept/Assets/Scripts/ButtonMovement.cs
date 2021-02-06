using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonMovement : MonoBehaviour
{
    public bool W;
    public bool S;
    public bool A;
    public bool D;
    public bool J;
    public bool L;

    public void WT()
    {
        W = true;
    }

    public void WF()
    {
        W = false;
    }
    //-------------------------W------------------------------------
    public void ST()
    {
        S = true;
    }

    public void SF()
    {
        S = false;
    }
    //--------------------------S-----------------------------------
    public void AT()
    {
        A = true;
    }

    public void AF()
    {
        A = false;
    }
    //---------------------------A----------------------------------
    public void DT()
    {
        D = true;
    }

    public void DF()
    {
        D = false;
    }
    //--------------------------D-----------------------------------
    public void JT()
    {
        J = true;
    }

    public void JF()
    {
        J = false;
    }
    //---------------------------J----------------------------------
    public void LT()
    {
        L = true;
    }

    public void LF()
    {
        L = false;
    }
    //---------------------------L----------------------------------
    public void Resset()
    {
        SceneManager.LoadScene("ENTC Mobile");
    }

    public void mainmenu()
    {
        SceneManager.LoadScene("Start");
    }
    void Update()
    {
        if (W)
        {
            Debug.Log("W pressed");
            transform.Translate(new Vector3(1, 0) * Time.deltaTime);
        }
        
        if (S)
        {
            Debug.Log("S pressed");
            transform.Translate(new Vector3(-1, 0) * Time.deltaTime);
        }

        if (A)
        {
            Debug.Log("A pressed");
            transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime);
        }

        if (D)
        {
            Debug.Log("D pressed");
            transform.Translate(new Vector3(0, 0, -1) * Time.deltaTime);
        }

        if (J)
        {
            Debug.Log("J Pressed");
            transform.Rotate(0, -1, 0, Space.Self);
        }

        if (L)
        {
            Debug.Log("L Pressed");
            transform.Rotate(0, 1, 0, Space.Self);
        }
    }
}
