using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{

    //Variables 
    public float score;
    public float Incrementoscore;
   
    public TMP_Text canvasText;
    private float time;
    

   
   

    
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        
        if(time <= 1)
        {
            time = 0;
            score += Incrementoscore;
            canvasText.text = "Score: " + score;

        }
        
    }
}
/*if (ind)
{
    timer += Time.deltaTime;
    if (timer >= MaxTime)
    {
        score++;
        ScoreText.text = score.ToString("00000");
        MaxTime = 0;
    }
}

if (Time.timeScale == 0)
{
    ind = false;
} 


score = 0;
        ScoreText = GetComponent<Text>();
        MaxTime = 0.1f; */