using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Maybe bring this to the collectibles manager and add a for loop that rotates all of the collectible in existence
public class Rotator : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collided with " + other.tag);
        Destroy(this.gameObject);
    }
}
