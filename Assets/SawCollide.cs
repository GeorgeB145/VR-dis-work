using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawCollide : MonoBehaviour
{
    [SerializeField] public GameObject piece;
    [SerializeField] public GameObject plank;

    [SerializeField] public ObjectSpawner objectSpawner;
    public float minimum_size = 0.2f;



    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "CutColl")
        {
            Debug.Log("Collid-er, I hardly know her");
            Vector3 saw_position = transform.position;
            Vector3 plank_position = collision.transform.position;
            Vector3 relative_saw_position = saw_position - plank_position;
            if (collision.gameObject.GetComponent<Plank>() != null)
            {
                
                Vector3 plank_left = collision.gameObject.GetComponent<Plank>().left_pos.position;
                Vector3 plank_right = collision.gameObject.GetComponent<Plank>().right_pos.position;

                float left_distance = Mathf.Abs(plank_left.x - saw_position.x);
                float right_distance = Mathf.Abs(plank_right.x - saw_position.x);

                if (left_distance < minimum_size || right_distance < minimum_size) { return; }
                objectSpawner.CreateNewPiece(left_distance, plank_left, -1);
                objectSpawner.CreateNewPiece(right_distance, plank_right, 1);

                Destroy(collision.gameObject);
            }
            

        }
    }

}
