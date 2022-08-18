using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score_checker : MonoBehaviour
{
    public int score;
    public Text txt;

    public static Score_checker instance;

    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void score_update()
    {
        score++;
        txt.text = "score : " + score;
        if (score % 25 == 0)
        {
            Player_Control.instance.speed = Player_Control.instance.speed + 0.25f;
        }
    }

}
