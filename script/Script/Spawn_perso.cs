using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_perso : MonoBehaviour
{

    public GameObject Perso;
    [SerializeField]
    Transform[] Spawn;
    // Start is called before the first frame update
    void Start()
    {
        
        Spawn = new Transform[transform.childCount];
        
        for (int i = 0; i < transform.childCount; i++)
        {
            Spawn[i] = transform.GetChild(i);
        }
    }

    void SpawnMonPerso()
    {
        int i = Random.Range(0, transform.childCount);
        Perso.transform.position = Spawn[i].transform.position;
    }
    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.F1))
        {
            SpawnMonPerso();
        }
    }
}
