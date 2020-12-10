using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object: MonoBehaviour
{
    public GameObject Cube;
    public GameObject Example;
    public Transform SpawnPoint;


    void Start()
    {

    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Q))
        {
           
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            OnEnable();
            Cube.GetComponent<MeshRenderer>().enabled = true;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            OnDisable();
            Cube.GetComponent<MeshRenderer>().enabled = false;
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            Inst();
            Cube.AddComponent<MeshRenderer>();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Destr();
            Destroy(Cube.GetComponent<MeshRenderer>());
        }

    }

    void OnEnable()
    {
        Cube.SetActive(true);
    }

    void OnDisable()
    {
        Cube.SetActive(false);
    }

    void Destr()
    {
        Destroy(Cube);
    }

    void Inst()
    {
        Cube = Instantiate(Example, SpawnPoint.position, SpawnPoint.rotation, transform);
    }

    void ObjAndComp()
    {

    }
}