using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Vector3 tra;
    public Vector3 offset;
    public float RotX = 0f, RotY = 0f;
    public GameObject Camera;
    public Vector3 Rot;
    
    void Start()
    {
        tra.x = 0f;
        tra.y = 0f;
        tra.z = 0f;
    }

    
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            tra.z = 0.1f;
            Movimento(tra);
            tra.z = 0f;
        }
        if(Input.GetKey(KeyCode.S))
        {
            tra.z = -0.1f;
            Movimento(tra);
            tra.z = 0f;
        }
        if(Input.GetKey(KeyCode.A))
        {
            tra.x = -0.1f;
            Movimento(tra);
            tra.x = 0f;
        }
        if(Input.GetKey(KeyCode.D))
        {
            tra.x = 0.1f;
            Movimento(tra);
            tra.x = 0f;
        }

        Rot.y = Input.GetAxis("Mouse X") * 2;
        transform.Rotate(Rot);
        
        

    }
    
    void Movimento(Vector3 tra)
    {
        transform.Translate(tra);
    }
}
