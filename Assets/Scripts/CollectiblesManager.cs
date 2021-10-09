using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectiblesManager : MonoBehaviour
{

    [SerializeField] private GameObject map;

    [SerializeField] private GameObject prefab;

    private float spawnLocationX, spawnLocationZ;

    [SerializeField] private int numberOfCollectibles;

    private int lastCheckChildCount = 0;

    // Start is called before the first frame update
    void Start()
    {

    }


    private void Update()
    {
        
        Transform[] ts = gameObject.GetComponentsInChildren<Transform>();
        if (lastCheckChildCount != ts.Length)
        {
            lastCheckChildCount = ts.Length; 
            Debug.Log(ts.Length);
            if (ts.Length < numberOfCollectibles)
            {
                SpawnNewCollectible();
            }
        }
        
    }


    private void SpawnNewCollectible()
    {
        float spawnLocationX = map.transform.position.x + (map.transform.localScale.x / 2) * Random.Range(-1f, 1f);
        float spawnLocationZ = map.transform.position.z + (map.transform.localScale.z / 2) * Random.Range(-1f, 1f);

        Instantiate(prefab, new Vector3(spawnLocationX, 0.5f, spawnLocationZ), Quaternion.identity).transform.SetParent(this.transform);

       

        Debug.Log("New Item going to spawn in: x=" + spawnLocationX + " z= " + spawnLocationZ);
    }

}
