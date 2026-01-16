using TMPro;
using UnityEngine;



public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject TitlePalnel;
    [SerializeField] TMP_Text Score_text;
    [SerializeField] bool debug=false;

    static GameManager instance;
    //public static GameManager Instance
    //(
    //   get (if (instance == null) )
    //);
    
    public int score { get; set; } = 0;


    
    void Start()
    {
        Time.timeScale = (debug)? 1.0f : 0.0f;
        TitlePalnel.SetActive(!debug);
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
