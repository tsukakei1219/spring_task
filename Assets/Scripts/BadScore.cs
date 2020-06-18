using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BadScore : MonoBehaviour
{
    public Text BadScoreText;

    int badscore;
    // Start is called before the first frame update
    void Start()
    {
        badscore = GameManager.GetBadScore();

        BadScoreText.text = string.Format("不正解:{0}", badscore);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
