using System;
using System.Diagnostics;
using System.Collections.Generic;
using UnityEngine;
using UnityOscLib;
public class GPS_OSC : MonoBehaviour
{
    public Transform tf;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LongHandler(OSCMessage message)
    {
        float longitude = (float)message.Data[0];
        tf.position = new Vector3(longitude, tf.position.y, tf.position.z);

    }
    public void LatHandler(OSCMessage message)
    {
        float lat = (float)message.Data[0];
        tf.position = new Vector3(tf.position.x,tf.position.y,lat); 
    }
}
