using System.Collections;
using UnityEngine;

public class firePrefab : MonoBehaviour
{
    public GameObject prefab; 
    public float speed = 999999f; 
    public float lifetime = 3f; 
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Vector3 spawnPosition = transform.position;
            spawnPosition.y += 1.4f;
            GameObject instance = Instantiate(prefab, spawnPosition, Quaternion.Euler(90, 0, 0));
            instance.GetComponent<Rigidbody>().velocity = transform.forward * speed*-1;
            Destroy(instance, lifetime);
        }
    }
}
