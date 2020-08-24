using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Youwin : MonoBehaviour
{
    public static int scoretowin = 0;
    public GameObject Textwin;
    public GameObject Restart;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoretowin = ScoreText.score;
        if (scoretowin >= 5)
        {
            Textwin.SetActive(true);
            Restart.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void RestartGame()
    {
        Time.timeScale = 1;
        scoretowin = 0;
        ScoreText.score = 0;
        Textwin.SetActive(false);
        Restart.SetActive(false);
        SceneManager.LoadScene("SampleScene");
    }
}

