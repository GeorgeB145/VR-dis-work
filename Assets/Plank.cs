using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plank : MonoBehaviour
{
    public Transform left_pos;
    public Transform right_pos;
    public float plank_length = 2;

    private void Start()
    {
        //transform.localScale = new Vector3(plank_length, 0.1f, 0.5f);
    }
}
