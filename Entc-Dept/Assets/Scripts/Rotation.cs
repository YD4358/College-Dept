using UnityEngine;

public class Rotation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.I))
        {
            Debug.Log("I Pressed");
            transform.Rotate(-1, 0, 0, Space.Self);
        }

        if (Input.GetKey(KeyCode.K))
        {
            Debug.Log("K Pressed");
            transform.Rotate(1, 0, 0, Space.Self);
        }
    }
}
