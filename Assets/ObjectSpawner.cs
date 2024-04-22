using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject piece_prefab;
    public GameObject plank_prefab;
    public Transform piece_spawn;
    public Transform plank_spawn;
    public float cut_width = 0.05f;

    public void CreateNewPiece(float length, Vector3 position, int offset_direction)
    {
        if (length >= 0.5f)
        {
            Vector3 offset = new Vector3((length - cut_width) / 2 * offset_direction, 0f, 0f);
            GameObject plank = Instantiate(plank_prefab, position - offset, piece_spawn.rotation);
            plank.transform.localScale = new Vector3(length - cut_width, 0.1f, 0.5f);
        }
        else
        {
            Vector3 offset = new Vector3((length - cut_width) / 2 * offset_direction, 0f, 0f);
            GameObject piece = Instantiate(piece_prefab, position - offset, piece_spawn.rotation);
            piece.transform.localScale = new Vector3(length - cut_width, 0.1f, 0.5f);
        }

        
    }

    public void CreateNewPlank()
    {
        GameObject plank = Instantiate(plank_prefab, plank_spawn.position, plank_spawn.rotation);
    }
}
