using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class midPipe_scpt : MonoBehaviour
{
    // Start is called before the first frame update
    public Score_UI score_UI;
    
    void Start()
    {
        score_UI = GameObject.FindGameObjectWithTag("logic").GetComponent<Score_UI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // layer 3 = Bird layer
        if (collision.gameObject.layer == 3)
        {
            score_UI.addScore(1);
        }
    }
}

