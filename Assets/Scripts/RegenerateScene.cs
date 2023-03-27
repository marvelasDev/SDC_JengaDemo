using UnityEngine;
using UnityEngine.SceneManagement;

public class RegenerateScene : MonoBehaviour
{
    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}