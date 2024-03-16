using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Create : MonoBehaviour
{
    public GameObject asteroid;
    public ParticleSystem system;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        if (Time.fixedTime % 3 == 0)
        {
            Vector3 position = new Vector3(Random.Range(44, 64), 132, Random.Range(-148, -128));
            Instantiate(asteroid, position, Quaternion.identity);
            Vector3 particlePosition = new Vector3(Random.Range(35, 80), 132, Random.Range(-150, -125));
            Instantiate(system, particlePosition, Quaternion.identity);
        }

    }
}
