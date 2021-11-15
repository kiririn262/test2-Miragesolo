using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballgenelater : MonoBehaviour
{
    public GameObject ballPrefab;
    public float span;
    float delta = 0;

    void Start()
    {

    }

    void Update()
    {
        this.delta += Time.deltaTime;
        if(this.delta > this.span)
        {
            this.delta = 0;
            Genelate();
        }
    }

    void Genelate()
    {
        GameObject go = Instantiate(ballPrefab) as GameObject;
        float px = Random.Range(-5.0f, 5.0f);
        float pz = Random.Range(-5.0f, 5.0f);

        go.transform.position = new Vector3(px, 5.0f, pz);
    }
}
