using UnityEngine;
using UnityEngine.SceneManagement;

public class AllButtonWork : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene("Level");
        Time.timeScale = 1.0f;
    }
}
