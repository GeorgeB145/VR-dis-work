using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawCollide : MonoBehaviour
{
    [SerializeField] public GameObject piece;
    [SerializeField] public GameObject plank;

    void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
        //if (collision.gameObject.tag == "CutColl")
        //{
           // Destroy(gameObject);
        //}
        //   plank.SetActive(false);
        // piece.SetActive(true);
    }
}
