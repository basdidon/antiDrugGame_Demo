using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    //public Transform farBackground;
    //public Transform middleBackground;
    public float lastXPos;
    public float amountMove = 0;

    public float cameraXmin = 0f;
    public float cameraYmin = -2f;

    public float cameraX;
    public float cameraY;

    // Start is called before the first frame update
    void Start()
    {
        //lastXPos = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (target.position.x < cameraXmin){
            cameraX = cameraXmin;
        }
        else {
            cameraX = target.position.x;
        }

        if(target.position.y< cameraYmin){
            cameraY = cameraYmin;
        }
        else
        {
            cameraY = target.position.y;
        }

        transform.position = new Vector3(cameraX,cameraY, transform.position.z);

        //Debug.Log("CameraX : " + cameraX);
        amountMove = transform.position.x - lastXPos;
        //Debug.Log("transform.position.x : " + transform.position.x);
        //Debug.Log("lastXPos : " + lastXPos);
        

        //farBackground.position = new Vector3(amountMove,transform.position.y,farBackground.position.z);
        //middleBackground.position = new Vector3(amountMove * 0.5f, middleBackground.position.y, middleBackground.position.z);
    }
}
