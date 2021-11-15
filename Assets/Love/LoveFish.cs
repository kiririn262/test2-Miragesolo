using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoveFish : MonoBehaviour
{
    public Transform neckBone;
    public GameObject watchTarget;
    public bool lookFlag;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    protected virtual void LateUpdate()
    {

        Quaternion look= new Quaternion(0, 0, 0, 1.0f);
        if (neckBone != null && lookFlag)
        {
            if (watchTarget != null)
            {
                var aim = this.watchTarget.transform.position - this.transform.position;
                look = Quaternion.LookRotation(aim, this.transform.up);
                //look = new Quaternion(look.x, /*look.z*/0,0 /*look.y*/, 1.0f);
                look = new Quaternion(-look.x, look.z,look.y, 1.0f);
                if (look.x < -0.6f || look.x > 0.6f || look.y < -0.6f || look.y > 0.6f || look.z < -0.6f || look.z > 0.6f) look = new Quaternion(0, 0, 0, 1.0f);

                Debug.Log(look);

            }
        }

        neckBone.localRotation = Quaternion.Slerp(neckBone.localRotation, look, Time.deltaTime*10);
        //neckBone.localRotation = look;

    }

    public void OnLook()
    {
        lookFlag = true;
    }
    public void OffLook()
    {
        lookFlag = false;
    }

}
