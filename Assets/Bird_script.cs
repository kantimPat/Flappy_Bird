using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bird_script : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D MyRigid;
    public float flap_step = 15;
    public Score_UI score_UI;
    public bool alive = true; // bird alive
    void Start()
    {
        gameObject.name = "Big Bird";
        score_UI = GameObject.FindGameObjectWithTag("logic").GetComponent<Score_UI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && alive )
        {
            MyRigid.velocity = Vector2.up * flap_step;
        }
        
    }

    // public void On(Collider2D collision){
    //     score_UI.game_over();
    //     alive = false;

    // }

    private void OnCollisionEnter2D(){
        score_UI.game_over();
        alive = !alive;
    }
}
