using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Gamescore : MonoBehaviour
{
    public Transform player;
    public TextMeshProUGUI uiText;
    // Start is called before the first frame update
    void Start()
    {
        uiText.rectTransform.anchoredPosition = new Vector3(0,55,0);
    }
    public void GameOver(float survivedTime){
        uiText.text = "You lost!\nYou survived for\n"+survivedTime.ToString("N2")+" seconds!";
        return;
    }
}
