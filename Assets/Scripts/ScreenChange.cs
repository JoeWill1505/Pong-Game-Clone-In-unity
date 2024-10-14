using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenChange : MonoBehaviour
{
    public void Single()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void Dual()
    {
        SceneManager.LoadSceneAsync(2);
    }
}
