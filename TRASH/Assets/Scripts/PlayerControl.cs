using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

    // Reference to the Prefab. Drag a Prefab into this field in the Inspector.
    public GameObject myPrefab;

    // This script will simply instantiate the Prefab when the game starts.
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Vector3 pos = transform.position;
            // Instantiate at player specific position and zero rotation.
            GameObject SandTile;
            SandTile = Instantiate(myPrefab, pos + new Vector3(-1.16f, 1.87f, 0), Quaternion.identity);
            // Move our position a step closer to the target.
            float step = 150f * Time.deltaTime; // calculate distance to move
            transform.position = Vector3.MoveTowards(transform.position, SandTile.transform.position, step);
            Debug.Log("Object was spawned, left of player position");
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Vector3 pos = transform.position;
            // Instantiate at player specific position and zero rotation.
            GameObject SandTile;
            SandTile = Instantiate(myPrefab, pos + new Vector3(1.16f, 1.87f, 0), Quaternion.identity);
            // Move our position a step closer to the target.
            float step = 150f * Time.deltaTime; // calculate distance to move
            transform.position = Vector3.MoveTowards(transform.position, SandTile.transform.position, step);
            Debug.Log("Object was spawned, right of player position");
        }
    }
}
