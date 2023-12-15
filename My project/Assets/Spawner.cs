using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float _delay = 0.2f;
    public GameObject _cube;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", _delay, _delay);
    }

    void Spawn()
    {
        Instantiate(_cube, new Vector3(Random.Range(-10,10),10,0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
