using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject piece_prefab;
    public GameObject plank_prefab;
    public Transform piece_spawn;
    public Transform plank_spawn;

    public void CreateNewPiece()
    {
        GameObject piece = Instantiate(piece_prefab, piece_spawn.position, piece_spawn.rotation);
    }

    public void CreateNewPlank()
    {
        GameObject plank = Instantiate(plank_prefab, plank_spawn.position, plank_spawn.rotation);
    }
}
