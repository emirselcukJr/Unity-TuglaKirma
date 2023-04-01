using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int skor;
    public int hak;

    public Text skorText;
    public Text hakText;

    private void Start()
    {
        hakText.text = "HAK : " + hak.ToString();
        skorText.text = "SKOR : " + skor.ToString();

    }

    public void HakUpdate(int countHak)
    {
        hak += countHak;
        if (hak<= 0)
        {
            hak = 0;
            
        }

        hakText.text = "HAK : " + hak.ToString();
    }

    public void SkorUpdate(int _skor)
    {
        skor += _skor;
        skorText.text = "SKOR : " + skor.ToString();
    }

}
