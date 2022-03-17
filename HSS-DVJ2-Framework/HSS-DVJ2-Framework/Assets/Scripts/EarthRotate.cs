using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthRotate : MonoBehaviour
{
    public GameObject sun;
    public float speed;
 
    // Update is called once per frame
    void Update() 
    {
        //Earth standalone day rotation
        transform.Rotate(0,-0.1f,0);

        //Orbit
        transform.RotateAround(sun.transform.position, new Vector3(0,-1,0), speed*Time.deltaTime*2);
    }
}
