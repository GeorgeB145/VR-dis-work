using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NonVRTesting : MonoBehaviour
{
    public ObjectSpawner obj;

    void Start()
    {
        
    }

    //script was developed by myself to act as a debug test when the simulation is run without a VR headset
    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            Debug.Log("Spawn new planks");
            obj.CreateNewPlank();
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {

        }
    }
}
