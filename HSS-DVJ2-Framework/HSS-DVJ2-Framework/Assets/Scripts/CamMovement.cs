using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMovement : MonoBehaviour
{
 //GENERIC
    public GameObject cam;
    public float speed = 10;
    public Vector2 motion;
    public Vector3 zoom;
    public bool planetLock = false;
    private Vector3 OGPos;
 // PlanetLock
     public Transform planetTransform;
    private Vector3 _camOffset;
    public float SmoothFactor = 0.5f;

    void Start()
    {
        _camOffset = transform.position - planetTransform.position;
        OGPos = transform.position;
        zoom = new Vector3(0, 0, 0.5f);
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha3)){
            if(!planetLock){
                planetLock = true;
            }else{
                planetLock = false;
                transform.position = OGPos;
            }
        }

        if(planetLock){
            Vector3 newPos = planetTransform.position +_camOffset;
            transform.position = Vector3.Slerp(transform.position, newPos, SmoothFactor);
        }else{
            motion = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
            cam.transform.Translate(motion * speed * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.Q))
        {
            cam.transform.Translate(zoom * speed * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.E))
        {
            cam.transform.Translate(-zoom * speed * Time.deltaTime);
        }


    }
}
