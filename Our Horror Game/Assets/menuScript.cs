using UnityEngine;
using UnityEngine.SceneManagement;

public class menuScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void PlayHome (int SceneID)
    {
        SceneManager.LoadScene(SceneID);
        
    }
      public void Back()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
       
    // Update is called once per frame
    public void QuitGame()
    {
        Application.Quit();
    }
}
