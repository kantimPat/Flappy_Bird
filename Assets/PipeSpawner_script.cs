using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PipeSpawner_script : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pipe ;
    public float spawn_time = 2;
    private float timer = 0;
    public float highoffset = 10;
    void Start()
    {
        pipe_Spawn();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawn_time){
            timer += Time.deltaTime;
        }
        else {
            pipe_Spawn();
            timer = 0;
        }
    }

    private void pipe_Spawn(){

        float minY = transform.position.y - highoffset;
        float maxY = transform.position.y + highoffset;
        Instantiate(pipe ,  new Vector3(transform.position.x , Random.Range(minY , maxY) , 0), transform.rotation );
    }
}
