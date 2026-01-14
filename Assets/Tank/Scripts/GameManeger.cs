using TMPro;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject TitlePalnel;
    [SerializeField] TMP_Text Score_text;

    public int score = 145;
    
    void Start()
    {
        Time.timeScale = 0.0f;
    }

    
    void Update()
    {
        Score_text.text = score.ToString("000000");
    }
    public void OnGameStart() 
    {
        TitlePalnel.SetActive(false);
        Time.timeScale = 1.0f;
    }
}
