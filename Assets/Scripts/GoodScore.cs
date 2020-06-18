using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoodScore : MonoBehaviour
{
    public Text GoodScoreText;

    int goodscore;

    // Start is called before the first frame update
    void Start()
    {
        goodscore = GameManager.GetGoodScore();

        GoodScoreText.text = string.Format("正解:{0}", goodscore);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
