using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {

    public GameObject Gegenstände;
    float x = 0;
	void Update () {
        float y = Random.Range(-0.85f, 5.24f);
        if(x < 1000)
        {
                Instantiate(Gegenstände, new Vector3((x + 1) * 6.0f, y, 0), Quaternion.identity);
                x++;
        }
	}
}
