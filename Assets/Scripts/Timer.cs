using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    private float seconds;

    // Start is called before the first frame update
    void Start()
    {
        seconds = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        // 時間をカウント
        seconds += Time.deltaTime;
        
        //　20秒後に画面遷移
        if (seconds >= 20.0f)
        {
            SceneManager.LoadScene("EndScene");
        }
    }
}
