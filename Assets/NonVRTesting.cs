using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NonVRTesting : MonoBehaviour
{
    public ObjectSpawner obj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
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
