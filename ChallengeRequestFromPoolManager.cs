using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PoolManager : MonoBehaviour
{
    // Dictionary<GameObject, Dictionary<int, Color >> fallingBalloons = new Dictionary<GameObject, Dictionary<int, Color>>();

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

    [SerializeField]
    private GameObject _bulletContainer; //Create a bullet container game object in the inspector

    [SerializeField]
    private GameObject _bulletPrefab;

    [SerializeField]
    private List<GameObject> _bulletPool;

    void Start()
    {
        /*GameObject smallballoons = new GameObject();
        int balloonNumbers = Random.Range(1, 200);
        Color _color = new Color(Random.value, Random.value, Random.value);
        fallingBalloons.Add(smallballoons, (balloonNumbers, _color));*/

        _bulletPool = GenerateBullets(10); //this automatically fills the array
    }

    List<GameObject> GenerateBullets(int amountOfBullets)
    {

        for (int i = 0; i < amountOfBullets; i++)
        {
            GameObject bullets = Instantiate(_bulletPrefab);
            bullets.transform.parent = _bulletContainer.transform; //now a child of the bullet container gameobject
            bullets.SetActive(false);

            _bulletPool.Add(bullets);

        }

        return _bulletPool;
    }

    public GameObject RequestBullet()
    {
        // loop through the bullet list
        foreach (var bullet in _bulletPool)
        {
            //checking for in - active bullets
            //found one? Set it active and return it to the player
            if (bullet.activeInHierarchy == false)
            {
                bullet.SetActive(true); //Here once setactive is true we return the bullet to the player
                return bullet;


            }
        }

        //If we are past this, the code below happens

        //if no bullets are found(it means they all in use)
        //generate x amount of bullet and run the RequestBullet method so it's added to the list
        GameObject newBullet = Instantiate(_bulletPrefab);
        newBullet.transform.parent = _bulletContainer.transform; //This adds it to the bulletcontainer list to keep it tidy
        newBullet.SetActive(true);
        _bulletPool.Add(newBullet);


        return newBullet; //After creating new bullet return the bullet to the user

        //checking for in - active bullets
        //found one? Set it active and return it to the player
        //if no bullets are found(it means they are all in use)
        //generate x amount of bullet and run the RequestBullet method so it's added to the list

    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField]
    private GameObject _bulletPrefab;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Communicate with the object pool system
            GameObject bullet = PoolManager.Instance.RequestBullet(); //When I request a bullet I might actually want to maitain a reference because I might wanna 
            //reposition the size or scale or position, so to do that the RequestBullet method has to return a GameObject 
            bullet.transform.position = Vector3.zero; //this positions the bullet at zero positionn



            //Request Bullet
        }
    }



}
