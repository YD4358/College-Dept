using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
   public void chngscne(string Name)
    {
        SceneManager.LoadScene(Name);
    }
}
