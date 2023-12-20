using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    public float speed = 10f;

    private Rigidbody _zombieRb;
    private GameObject _player;
    private SpawnManager _spawnManager;

    // Start is called before the first frame update
    void Start()
    {
        _zombieRb = GetComponent<Rigidbody>();
        _player = GameObject.Find("Player");
        _spawnManager = GameObject.Find("Spawn Manager").GetComponent<SpawnManager>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(_spawnManager.isGameActive)
        {
            Vector3 lookDirection = (_player.transform.position - transform.position).normalized;
            _zombieRb.AddForce(lookDirection * speed);
        }
        
    }
}
