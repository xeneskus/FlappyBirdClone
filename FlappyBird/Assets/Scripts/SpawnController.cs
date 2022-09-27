using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    [SerializeField] GameObject pipesPrefab;

    [SerializeField] float minY;

    [SerializeField] float maxY;

    [SerializeField] float x;

    [SerializeField] float interval;


    void Start()
    {
        InvokeRepeating("spawn", interval, interval);
    }

    private void spawn()
    {
        GameObject instance = Instantiate(pipesPrefab);
        instance.transform.position = new Vector2(x, Random.Range(minY, maxY));
        instance.transform.SetParent(transform);
    }
}
