using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePipe_script : MonoBehaviour
{
    // Start is called before the first frame update
    public float bird_speed = 10;
    public float deadzone = -45;
    public Score_UI score_UI;
    void Start()
    {
        score_UI = GameObject.FindGameObjectWithTag("logic").GetComponent<Score_UI>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3.left * bird_speed) * Time.deltaTime;

        if (transform.position.x < deadzone){
            Debug.Log("Pipe Deleted");
            Destroy(gameObject);
        }
    }

    
}
