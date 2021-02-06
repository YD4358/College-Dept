using UnityEngine;
using UnityEngine.SceneManagement;

public class Activate : MonoBehaviour
{
    public GameObject StartCanvas;
    public GameObject Canvas;
    public bool check;
   
    public void Disaable()
    {
        check = true;
    }
    public void enaable()
    {
        check = false;
    }

    void Update()
    {
        if (check)
        {
            StartCanvas.SetActive(false);
            Canvas.SetActive(true);
        }

        if (!check)
        {
            StartCanvas.SetActive(true);
            Canvas.SetActive(false);
        }
    }
}
