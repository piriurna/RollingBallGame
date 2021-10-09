using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollisionManager : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI countText;
    private int count = 0;


    private void Start()
    {
        displayCounter();
    }


    private void OnCollisionEnter(Collision collision)
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision with " + other.tag);
        if (other.CompareTag("Collectible"))
        {
            other.gameObject.SetActive(false);
            count++;
            displayCounter();
        }
       
    }


    private void displayCounter()
    {
        countText.text = "Count: " + count.ToString();
    }
}
