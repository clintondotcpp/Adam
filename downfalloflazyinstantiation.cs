using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    private static SpawnManager _instance;
    public static SpawnManager Instance
    {
        get
        {
            if (_instance == null)
            {
                GameObject go = new GameObject("Spawn_Manager");
                go.AddComponent<SpawnManager>();

            }

            return _instance;
        }
    }

    void Awake()
    {
        _instance = this;
    }

    [SerializeField]
    private GameObject prefab; //To use lazy instantion you have to dynamically instantiate objects from a destination folder

    public void CreateNew()
    {
        Instantiate(prefab);
    }

}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    void Start()
    {
        GameManager.Instance.DisplayMessage();

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnManager.Instance.CreateNew();

        }
    }
}
