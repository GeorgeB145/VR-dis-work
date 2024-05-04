using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Samples.StarterAssets;

public class Bin : MonoBehaviour
{
    //script was developed myself but not implemented in the project
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Destroying");
        if (collision.gameObject.tag == "CutColl")
        {
            Debug.Log("Destroying");
            Destroy(collision.gameObject);
        }
    }
}
