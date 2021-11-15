using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class effectdirector : MonoBehaviour
{
    public GameObject ball;
    public ParticleSystem p1;
    public ParticleSystem p2;

    void Start()
    {
        GameObject Ball = GameObject.FindGameObjectWithTag("ball");
        this.transform.parent = Ball.transform;
    }

    // Start is called before the first frame update
    public void First()
    {
        ParticleSystem pp1 = Instantiate(p1, ball.transform.position, Quaternion.Euler(0, 0, 0)) as ParticleSystem;
    }

    public void Click()
    {
        ParticleSystem pp2 = Instantiate(p2, ball.transform.position, Quaternion.Euler(0, 0, 0)) as ParticleSystem;
    }
}
