using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Percentage : MonoBehaviour
{
    public Text PercentageText;

    double percentage;
    // Start is called before the first frame update
    void Start()
    {
        percentage = GameManager.GetPercentage();

        PercentageText.text = string.Format("正解率:{0}%", percentage);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
