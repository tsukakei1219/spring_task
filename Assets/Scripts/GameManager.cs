using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // 敵の手を表す配列
    public GameObject[] Janken = new GameObject[6];
    int number;
    public static int GoodScore = 0;
    public static int BadScore = 0;
    public static int TotalCount = 0;
    public static double Percentage = 0;

    public bool doesHyojiWinGoo;
    public bool doesHyojiWinChoki;
    public bool doesHyojiWinPaa;
    public bool doesHyojiLoseGoo;
    public bool doesHyojiLoseChoki;
    public bool doesHyojiLosePaa;

    // numberの値を0～2の中からランダムで決める
    void randomimg()
    {
        number = Random.Range(0, Janken.Length);
    }

    // Start is called before the first frame update
    void Start()
    {
        doesHyojiWinGoo = false;
        doesHyojiWinChoki = false;
        doesHyojiWinPaa = false;
        doesHyojiLoseGoo = false;
        doesHyojiLoseChoki = false;
        doesHyojiLosePaa = false;
        Janken[0].SetActive(false);
        Janken[1].SetActive(false);
        Janken[2].SetActive(false);
        Janken[3].SetActive(false);
        Janken[4].SetActive(false);
        Janken[5].SetActive(false);

        randomimg();
        Janken[number].SetActive(true);// number=0の時に青グーの画像、1で青チョキ、2で青パー、3で赤グー、4で赤チョキ、5で赤パーを表示する
        if (number == 0)
        {
            doesHyojiWinGoo = true;
        }
        else if (number == 1)
        {
            doesHyojiWinChoki = true;
        }
        else if (number == 2)
        {
            doesHyojiWinPaa = true;
        }
        else if (number == 3)
        {
            doesHyojiLoseGoo = true;
        }
        else if (number == 4)
        {
            doesHyojiLoseChoki = true;
        }
        else if (number == 5)
        {
            doesHyojiLosePaa = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void JankenStart()
    {
        doesHyojiWinGoo = false;
        doesHyojiWinChoki = false;
        doesHyojiWinPaa = false;
        doesHyojiLoseGoo = false;
        doesHyojiLoseChoki = false;
        doesHyojiLosePaa = false;

        Janken[number].SetActive(false);
        randomimg();
        Janken[number].SetActive(true);
        if (number == 0)
        {
            doesHyojiWinGoo = true;
        }
        else if (number == 1)
        {
            doesHyojiWinChoki = true;
        }
        else if (number == 2)
        {
            doesHyojiWinPaa = true;
        }
        else if (number == 3)
        {
            doesHyojiLoseGoo = true;
        }
        else if (number == 4)
        {
            doesHyojiLoseChoki = true;
        }
        else if (number == 5)
        {
            doesHyojiLosePaa = true;
        }
    }

    public void PushButtonGoo()
    {
        TotalCount++;
        if (doesHyojiWinChoki == true)
        {
            GoodScore++;
            JankenStart();
        }
        else if(doesHyojiLosePaa == true)
        {
            GoodScore++;
            JankenStart();
        }
        else
        {
            BadScore++;
        }
    }

    public void PushButtonChoki()
    {
        TotalCount++;
        if (doesHyojiWinPaa == true)
        {
            GoodScore++;
            JankenStart();
        }
        else if (doesHyojiLoseGoo == true)
        {
            GoodScore++;
            JankenStart();
        }
        else
        {
            BadScore++;
        }
    }

    public void PushButtonPaa()
    {
        TotalCount++;
        if (doesHyojiWinGoo == true)
        {
            GoodScore++;
            JankenStart();
        }
        else if (doesHyojiLoseChoki == true)
        {
            GoodScore++;
            JankenStart();
        }
        else
        {
            BadScore++;
        }
    }

    public static int GetGoodScore()
    {
        return GoodScore;
    }

    public static int GetBadScore()
    {
        return BadScore;
    }

    public static double GetPercentage()
    {
        Percentage = (GoodScore * 100) / TotalCount;
        return Percentage;
    }
}
