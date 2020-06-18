using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{

    public GameObject[] Button = new GameObject[3];

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*void Shuffle(GameObject[] num)
    {
        for(int i=0;i<num.Length;i++)
        {
            GameObject temp = num[i];

            int randomIndex = Random.Range(0, num.Length);

            num[i] = num[randomIndex];

            num[randomIndex] = temp;
        }
    }*/



}
