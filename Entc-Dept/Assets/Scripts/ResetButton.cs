using UnityEngine;

public class ResetButton : MonoBehaviour
{
    public GameObject player;
    public GameObject cam;
    public void rstpos()
    {
        player.transform.position = new Vector3(-1, 0.2f, 0);
        player.transform.rotation = Quaternion.Euler(0, 90, 0);
    }
    public void rstrot()
    {
        cam.transform.rotation = Quaternion.Euler(0, 180, 0);
    }
}
