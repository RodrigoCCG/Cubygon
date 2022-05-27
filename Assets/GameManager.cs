using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    private bool gameEnded=false;
    private float startTime;
    private float endTime;
    public GameObject gameoverUI;
    public GameObject resetButton;
    public GameObject backGround;
    public GameObject menuButton;
    void Start(){
        startTime = Time.time;
    }
    public void EndGame(){
        if(!gameEnded){
            gameEnded = true;
            endTime = Time.time;
            gameoverUI.SetActive(true);
            resetButton.SetActive(true);
            menuButton.SetActive(true);
            backGround.SetActive(true);
            FindObjectOfType<AudioBehavior>().playGameOver();
            FindObjectOfType<Gamescore>().GameOver(endTime-startTime);
            FindObjectOfType<PlayerBehaviour>().enabled = false;
        }
    }

    public void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void ReturnToMenu(){
        SceneManager.LoadScene(0);
    }
}
