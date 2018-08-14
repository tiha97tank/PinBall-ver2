using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TOKUTEN : MonoBehaviour
{


    public GameObject Tokuten;
    private int score = 0;


    // Use this for initialization
    void Start()
    {
        this.Tokuten = GameObject.Find("tokutenText");


    }


    // Update is called once per frame
    void Update()
    {

        


    }
    void OnCollisionEnter(Collision other)
    {
        this.Tokuten.GetComponent<Text>().text = "スコア " + score.ToString();

        if (other.gameObject.tag == "SmallStarTag")
        {
            score += 10;
        }
        else if (other.gameObject.tag == "LargeStarTag")
        {
            score += 15;
        }
        else if (other.gameObject.tag == "SmallCloudTag")
        {
            score += 5;
        }
        else if (other.gameObject.tag == "LargeCloudTag")
        {
            score += 15;
        }

    }
}