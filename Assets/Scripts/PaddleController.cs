using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{

    public string leftKey, rightKey;
    public float speed;
    
    void Update()
    {
        PaddleMovement();
    }

    void PaddleMovement()
    {
        if(Input.GetKey(leftKey) && transform.position.x > -4){
            transform.Translate(Vector3.left * Time.deltaTime * speed, Space.World);
        }
        if(Input.GetKey(rightKey) && transform.position.x < 4){
            transform.Translate(Vector3.right * Time.deltaTime * speed, Space.World);
        }
    }

}
