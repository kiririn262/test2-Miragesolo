using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    public GameObject ball;
    float delta = 0;
    public float clean = 60.0f;
    public float lag = 0.8f;

    // Start is called before the first frame update
    void Start()
    {
        GameObject flog = GameObject.FindGameObjectWithTag("HY");
        this.transform.parent = flog.transform;
    }

    void Update()
    {
        this.delta += Time.deltaTime;
        if(this.delta > this.clean)
        {
            this.delta = 0;
            Destroy(ball);
        }
    }

    public void Destroy()
    {
        Destroy(ball, lag);
    }
}
