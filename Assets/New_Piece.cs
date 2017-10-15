using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class New_Piece : MonoBehaviour {

    public GameObject[] blocks;

    // Use this for initialization
    void Start () {
        spawnNext();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void spawnNext()
    {
        // Random Index
        int i = Random.Range(0, blocks.Length);

        // Spawn Group at current Position
        Instantiate(blocks[i],
                    transform.position,
                    Quaternion.identity);
    }
}
