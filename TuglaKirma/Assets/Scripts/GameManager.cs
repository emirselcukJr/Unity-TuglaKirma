using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int skor;
    public int hak;

    public Text skorText;
    public Text hakText;

    public bool gameOver;

    [SerializeField]
    GameObject gameOverPanel;

    private void Start()
    {
        hakText.text = "HAK : " + hak.ToString();
        skorText.text = "SKOR : " + skor.ToString();

        gameOverPanel.GetComponent<CanvasGroup>().alpha = 0f;



    }

    public void HakUpdate(int countHak)
    {
        hak += countHak;
        if (hak<= 0)
        {
            hak = 0;
            GameOver();
            
        }

        hakText.text = "HAK : " + hak.ToString();
    }

    public void SkorUpdate(int _skor)
    {
        skor += _skor;
        skorText.text = "SKOR : " + skor.ToString();
    }

    void GameOver()
    {
        gameOver = true;

        gameOverPanel.GetComponent<CanvasGroup>().DOFade(1, .5f);
    }


    public void ReStart()
    {
        SceneManager.LoadScene("SampleScene");
        
    }

    public void QuitApp()
    {
        Application.Quit();
    }

}
