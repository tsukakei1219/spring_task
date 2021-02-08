using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // 問題を表す配列
    public GameObject[] EnglishWord = new GameObject[6];
    // 選択肢1を表す配列
    public GameObject[] EnglishSelect_1 = new GameObject[6];
    // 選択肢2を表す配列
    public GameObject[] EnglishSelect_2 = new GameObject[6];
    // 選択肢3を表す配列
    public GameObject[] EnglishSelect_3 = new GameObject[6];
    int Number;
    int SelectNumber;
    int number_answer;
    int number_select_1;
    int number_select_2;
    int number_select_3;
    public static int GoodScore = 0;
    public static int BadScore = 0;
    public static int TotalCount = 0;
    public static double Percentage = 0;

    public bool doesHyojiWent;
    public bool doesHyojiShowed;
    public bool doesHyojiKnew;
    public bool doesHyojiFelt;
    public bool doesHyojiSaw;
    public bool doesHyojiListened;
    // public bool doesHyoji_1;
    // public bool doesHyoji_5;

    // numberの値を0～5の中からランダムで決める
    void Randomimg()
    {
        Number = Random.Range(0, EnglishWord.Length);
        SelectNumber = Random.Range(0, EnglishWord.Length);
    }
    // 選択肢を決める
    void SelectRandoming()
    {
        if(Number > 4)
        {
            // doesHyoji_5 = true;
            SelectNumber = Random.Range(Number - 5, Number);
        }
        else
        {
            // doesHyoji_1 = true;
            SelectNumber = Random.Range(0, 6);
        }
        
    }
    // 選択肢表示
    /* void ShowSelect(int Number, int SelectNumber)
    {
        number_answer = Number;
        number_select_1 = SelectNumber;
        EnglishSelect_1[number_select_1].SetActive(true);
        SelectRandoming();
        number_select_2 = SelectNumber;
        while(number_select_2 == number_select_1)
        {
            SelectRandoming();
            number_select_2 = SelectNumber;
        }
        EnglishSelect_2[number_select_2].SetActive(true);
        SelectRandoming();
        number_select_3 = SelectNumber;
        while(number_select_3 == number_select_1 || number_select_3 == number_select_2)
        {
            if(number_select_1 != number_answer && number_select_2 != number_answer)
            {
                number_select_3 = number_answer;
                break;
            }
            SelectRandoming();
            number_select_3 = SelectNumber;
        }
        EnglishSelect_3[number_select_3].SetActive(true);
    }*/

    // Start is called before the first frame update
    void Start()
    {
        doesHyojiWent = false;
        doesHyojiShowed = false;
        doesHyojiKnew = false;
        doesHyojiFelt = false;
        doesHyojiSaw = false;
        doesHyojiListened = false;
        // doesHyoji_1 = false;
        // doesHyoji_5 = false;
        EnglishWord[0].SetActive(false);
        EnglishWord[1].SetActive(false);
        EnglishWord[2].SetActive(false);
        EnglishWord[3].SetActive(false);
        EnglishWord[4].SetActive(false);
        EnglishWord[5].SetActive(false);
        EnglishSelect_1[0].SetActive(false);
        EnglishSelect_1[1].SetActive(false);
        EnglishSelect_1[2].SetActive(false);
        EnglishSelect_1[3].SetActive(false);
        EnglishSelect_1[4].SetActive(false);
        EnglishSelect_1[5].SetActive(false);
        EnglishSelect_2[0].SetActive(false);
        EnglishSelect_2[1].SetActive(false);
        EnglishSelect_2[2].SetActive(false);
        EnglishSelect_2[3].SetActive(false);
        EnglishSelect_2[4].SetActive(false);
        EnglishSelect_2[5].SetActive(false);
        EnglishSelect_3[0].SetActive(false);
        EnglishSelect_3[1].SetActive(false);
        EnglishSelect_3[2].SetActive(false);
        EnglishSelect_3[3].SetActive(false);
        EnglishSelect_3[4].SetActive(false);
        EnglishSelect_3[5].SetActive(false);

        Randomimg();
        EnglishWord[Number].SetActive(true);// Number=1の時にWentを表示する
        // ShowSelect(Number, SelectNumber);
        ///////////////////////////////////////////////////////
        number_answer = Number;
        number_select_1 = SelectNumber;
        EnglishSelect_1[number_select_1].SetActive(true);
        SelectRandoming();
        number_select_2 = SelectNumber;
        while(number_select_2 == number_select_1)
        {
            SelectRandoming();
            number_select_2 = SelectNumber;
        }
        EnglishSelect_2[number_select_2].SetActive(true);
        SelectRandoming();
        number_select_3 = SelectNumber;
        if(number_select_1 != number_answer && number_select_2 != number_answer)
        {
            number_select_3 = number_answer;
        }
        else
        {
            while(number_select_3 == number_select_1 || number_select_3 == number_select_2)
            {
                SelectRandoming();
                number_select_3 = SelectNumber;
            }
        }

        EnglishSelect_3[number_select_3].SetActive(true);
        /////////////////////////////////////////////////////////
        if (Number == 0)
        {
            doesHyojiWent = true;
        }
        else if (Number == 1)
        {
            doesHyojiShowed = true;
        }
        else if (Number == 2)
        {
            doesHyojiKnew = true;
        }
        else if (Number == 3)
        {
            doesHyojiFelt = true;
        }
        else if (Number == 4)
        {
            doesHyojiSaw = true;
        }
        else if (Number == 5)
        {
            doesHyojiListened = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameStart()
    {
        doesHyojiWent = false;
        doesHyojiShowed = false;
        doesHyojiKnew = false;
        doesHyojiFelt = false;
        doesHyojiSaw = false;
        doesHyojiListened = false;

        EnglishWord[Number].SetActive(false);
        EnglishSelect_1[number_select_1].SetActive(false);
        EnglishSelect_2[number_select_2].SetActive(false);
        EnglishSelect_3[number_select_3].SetActive(false);
        Randomimg();
        EnglishWord[Number].SetActive(true);
        // ShowSelect(Number, SelectNumber);
        ///////////////////////////////////////////////////////
        number_answer = Number;
        number_select_1 = SelectNumber;
        EnglishSelect_1[number_select_1].SetActive(true);
        SelectRandoming();
        number_select_2 = SelectNumber;
        while(number_select_2 == number_select_1)
        {
            SelectRandoming();
            number_select_2 = SelectNumber;
        }
        EnglishSelect_2[number_select_2].SetActive(true);
        SelectRandoming();
        number_select_3 = SelectNumber;
        if(number_select_1 != number_answer && number_select_2 != number_answer)
        {
            number_select_3 = number_answer;
        }
        else
        {
            while(number_select_3 == number_select_1 || number_select_3 == number_select_2)
            {
                SelectRandoming();
                number_select_3 = SelectNumber;
            }
        }
        EnglishSelect_3[number_select_3].SetActive(true);
        /////////////////////////////////////////////////////////
        if (Number == 0)
        {
            doesHyojiWent = true;
        }
        else if (Number == 1)
        {
            doesHyojiShowed = true;
        }
        else if (Number == 2)
        {
            doesHyojiKnew = true;
        }
        else if (Number == 3)
        {
            doesHyojiFelt = true;
        }
        else if (Number == 4)
        {
            doesHyojiSaw = true;
        }
        else if (Number == 5)
        {
            doesHyojiListened = true;
        }
    }

    public void PushButtonGo()
    {
        TotalCount++;
        if (doesHyojiWent == true)
        {
            GoodScore++;
            GameStart();
        }
        else
        {
            BadScore++;
        }
    }

    public void PushButtonShow()
    {
        TotalCount++;
        if (doesHyojiShowed == true)
        {
            GoodScore++;
            GameStart();
        }
        else
        {
            BadScore++;
        }
    }

    public void PushButtonKnow()
    {
        TotalCount++;
        if (doesHyojiKnew == true)
        {
            GoodScore++;
            GameStart();
        }
        else
        {
            BadScore++;
        }
    }

    public void PushButtonFeel()
    {
        TotalCount++;
        if (doesHyojiFelt == true)
        {
            GoodScore++;
            GameStart();
        }
        else
        {
            BadScore++;
        }
    }

    public void PushButtonSee()
    {
        TotalCount++;
        if (doesHyojiSaw == true)
        {
            GoodScore++;
            GameStart();
        }
        else
        {
            BadScore++;
        }
    }

    public void PushButtonListen()
    {
        TotalCount++;
        if (doesHyojiListened == true)
        {
            GoodScore++;
            GameStart();
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