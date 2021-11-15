using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flow : MonoBehaviour
{
    float delta = 0;
    public float changetime;
    public float endtime;
    public GameObject f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if(this.delta <= changetime) right();

        if(changetime < this.delta) left();

        if(this.delta > endtime) this.delta = 0;
    }

    public void right()
    {
        f.transform.position = new Vector3 (14.0f, -2.9f, 17.6f);
    }

    public void left()
    {
        f.transform.position = new Vector3(-7.0f, -2.9f, 17.6f);
    }
}
