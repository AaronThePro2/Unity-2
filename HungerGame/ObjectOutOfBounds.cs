using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectOutOfBounds : MonoBehaviour
{
    private float topBound = 30;
    private float lowerBound = -10;

    public static bool Gameover = false;

    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        } else if (transform.position.z < lowerBound) {
            Debug.Log("Game over");
            Gameover = true;
            Destroy(gameObject);
        }
    }
}
