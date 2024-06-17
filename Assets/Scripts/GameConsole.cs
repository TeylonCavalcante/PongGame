using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    private int score1 = 0;
    private int score2 = 0;
    public int pointsToWin;
    public GameObject Panel;
    public TMP_Text playerWinText;
    public TMP_Text score;
    public AudioSource scoreSound;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore(bool isPlayer1)
    {
        //Checar quem pontuou
        //Adicionar a pontuação na respectiva variável
        //Atualizar o Text
        if (isPlayer1)
        {
            score1++;

            if (score1 >= pointsToWin)
            {
                Debug.Log("Vitória do jogador 1");
                playerWinText.text = "Player 1 won";
                Panel.SetActive(true);
                Time.timeScale = 0;
            }
        }
        else
        {
            score2++;

            if (score2 >= pointsToWin)
            {
                Debug.Log("Vitória do jogador 2");
                playerWinText.text = "Player 2 won";
                Panel.SetActive(true);
                Time.timeScale = 0;
            }
        }
        scoreSound.Play();
        score.text = "Score " + score1.ToString() + ":" + score2.ToString();
    }
    public void RestartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
}