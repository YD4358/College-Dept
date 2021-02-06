using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    public int Speed = 1;
    public string Scenename;

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            Speed = 5;
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            Speed = 1;
        }

        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("W pressed");
            transform.Translate(new Vector3(1, 0) * Speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("S pressed");
            transform.Translate(new Vector3(-1, 0) * Speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("A pressed");
            transform.Translate(new Vector3(0, 0, 1) * Speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("D pressed");
            transform.Translate(new Vector3(0, 0, -1) * Speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.J))
        {
            Debug.Log("J Pressed");
            transform.Rotate(0, -0.5f, 0, Space.Self);
        }

        if (Input.GetKey(KeyCode.L))
        {
            Debug.Log("L Pressed");
            transform.Rotate(0, 0.5f, 0, Space.Self);
        }

        if (Input.GetKey(KeyCode.R))
        {
            Debug.Log("R Pressed");
            SceneManager.LoadScene(Scenename);
        }

    }
}
