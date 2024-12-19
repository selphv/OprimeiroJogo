using UnityEngine;
using UnityEngine.SceneManagement;
public class GamerManager : MonoBehaviour
{
    //determina se o jogou ja deu game over ou nao 
    bool gameHasEnded = false;

    public float restartDelay = 1f;

    public GameObject completeLevelUI;
    public void CompleteLevel()
    {
        
        completeLevelUI.SetActive(true);
    }
   
    //variavel publica que vai ser implementada nos outros scripts para fazer o game over
    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER");

            //invorcara o void restart e restartDelay serve para ficar mais fluido o recomeço da fase  
            Invoke("Restart", restartDelay);

            
        }
    }

    //resetara a cena fazendo o joga reiniar 
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
