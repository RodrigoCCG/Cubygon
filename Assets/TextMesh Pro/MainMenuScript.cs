using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor;

public class MainMenuScript : MonoBehaviour
{
    public Canvas menuCanvas;
    public Canvas helpCanvas;
    void Start(){
        helpCanvas.gameObject.SetActive(false);
        menuCanvas.gameObject.SetActive(true);
    }
    public void LoadGame(){
        SceneManager.LoadScene("Cubygon");
    }
    public void OpenTutorial(){
        helpCanvas.gameObject.SetActive(true);
        menuCanvas.gameObject.SetActive(false);
    }
    public void OpenMenu(){
        helpCanvas.gameObject.SetActive(false);
        menuCanvas.gameObject.SetActive(true);
    }
}
