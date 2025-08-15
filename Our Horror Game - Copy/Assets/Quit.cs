using UnityEngine;
using UnityEngine.SceneManagement;

public class MS : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // Update is called once per frame
    public void Quitgame()
    {
        Application.Quit();
    }
}
