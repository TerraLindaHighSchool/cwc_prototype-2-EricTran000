/** 
 * Detects if an object is colliding with it and deletes it if so
 * Author: Eric Tran
 * Version: 4/18/2022
*/using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
