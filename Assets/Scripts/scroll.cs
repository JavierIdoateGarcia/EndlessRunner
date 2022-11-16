using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scroll : MonoBehaviour
{
    // Start is called before the first frame update
    public float scrollSpeed;
    public GameObject start;
    public GameObject end;
    public GameObject[] grounds;
    public GameObject[] cactus;
    public GameObject[] pajaro;
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
    //transform.Translate(Vector2.left * scrollspeed * Time.deltaTime);
        transform.Translate(Vector3.left * scrollSpeed * Time.deltaTime);
        //transform.position = new Vector3(transform.position.x)
        RespawnGround();
    }

    void RespawnGround()
    {
        foreach (GameObject go in grounds)
        {
            if (go.transform.position.x <= end.transform.position.x)
            {
                go.transform.position=new Vector3(start.transform.position.x,go.transform.position.y,go.transform.position.z);
            }
        }

        foreach (GameObject cactu in cactus)
        {
            if (cactu.transform.position.x <= end.transform.position.x)
            {
                cactu.transform.position= new Vector3(start.transform.position.x, cactu.transform.position.y, cactu.transform.position.z);
            }
        }

        foreach (GameObject pajaro in pajaro)
        {
            if (pajaro.transform.position.x <= end.transform.position.x)
            {
                pajaro.transform.position = new Vector3(start.transform.position.x, pajaro.transform.position.y, pajaro.transform.position.z);
            }
        }

    }
}
    
