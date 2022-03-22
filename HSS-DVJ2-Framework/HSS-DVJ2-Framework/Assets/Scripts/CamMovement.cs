using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMovement : MonoBehaviour
{
 //GENERIC
    public GameObject cam;
    public float speed = 10;
    private Vector2 motion;
    private Vector3 zoom;
    public bool planetLock = false;
    private Vector3 OGPos;
    private Vector3 newPos;
 // PlanetLock
    //private Vector3 _camOffset;
    public float SmoothFactor = 0.5f;

//Planets
    public GameObject Mercury;
    public GameObject Venus;
    public GameObject Earth;
    public GameObject Mars;
    public GameObject Jupiter;
    public GameObject Saturn;
    public GameObject Uranus;
    public GameObject Neptune;

    void Start()
    {
       // _camOffset = (0f,0f,0f);
        OGPos = transform.position;
        zoom = new Vector3(0, 0, 0.5f);
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1)){
           if(!planetLock)planetLock = true;
            newPos = Mercury.transform.position;
        }
        if(Input.GetKeyDown(KeyCode.Alpha2)){
           if(!planetLock)planetLock = true;
            newPos = Venus.transform.position;
        }
        if(Input.GetKeyDown(KeyCode.Alpha3)){
            if(!planetLock)planetLock = true;
            newPos = Earth.transform.position;
        }
        if(Input.GetKeyDown(KeyCode.Alpha4)){
           if(!planetLock)planetLock = true;
            newPos = Mars.transform.position;
          
        }
        if(Input.GetKeyDown(KeyCode.Alpha5)){
           if(!planetLock)planetLock = true;
            newPos = Jupiter.transform.position;
          
        }
        if(Input.GetKeyDown(KeyCode.Alpha6)){
           if(!planetLock)planetLock = true;
            newPos = Saturn.transform.position;
          
        }
        if(Input.GetKeyDown(KeyCode.Alpha7)){
            if(!planetLock)planetLock = true;
            newPos = Uranus.transform.position;
          
        }
        if(Input.GetKeyDown(KeyCode.Alpha8)){
            if(!planetLock)planetLock = true;
            newPos = Neptune.transform.position;
        }

         if(Input.GetKeyDown(KeyCode.Alpha9)){
            planetLock = false;
            newPos = OGPos;
        }



        if(planetLock){
            transform.position = Vector3.Slerp(transform.position, newPos, SmoothFactor);
        }

        if(!planetLock)
        {
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
