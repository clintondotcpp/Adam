using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Turn this class into a Singleton for easy accessibility

    //Pregenerate a list of bullets using the bullet prefab





public class PoolManager : MonoBehaviour
{

    private static PoolManager _instance;
    public static PoolManager Instance
    {
        get
        {
            if (_instance == null)
            {
                Debug.LogError("is null ");



            }
            return _instance;
        }
    }

    void Awake()
    {
        _instance = this;
    }

    //Pregenerate a list of bullets using a bullet prefab

    [SerializeField]
    private GameObject _bulletContainer; //Create a bullet container game object in the inspector as a child Of The Pool_Manager gameobject, going to allow us organize out hierachy, so that create bullets are stored her

    [SerializeField]
    private GameObject _bulletPrefab; //PoolManager has to know about the bullet prefab

    [SerializeField]
    private List<GameObject> _bulletPool;

    void Start()
    {
        _bulletPool = GenerateBullets(10); //this automatically fills the array, automatically reeturns bullets
    }

    List<GameObject> GenerateBullets(int amountOfBullets)  //The game object will be stored or populated in a bulletpool
    {

        for (int i = 0; i < amountOfBullets; i++)
        {
            GameObject bullets = Instantiate(_bulletPrefab);
            bullets.transform.parent = _bulletContainer.transform; //this makes bullets now a child of the _bulletcontainer gameobject
            bullets.SetActive(false); //We make it invisible

            _bulletPool.Add(bullets);

        }

        return _bulletPool;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        //Destroy(this.gameObject, 1f);   //attached to the prefab
    }


}
