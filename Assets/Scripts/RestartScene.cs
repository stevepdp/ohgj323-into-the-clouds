using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartScene : MonoBehaviour
{
    public void RestartThisScene() => SceneManager.LoadScene(0);
}
