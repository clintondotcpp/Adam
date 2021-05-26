using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//Create 4 scenes in the inspector, attach it to build settings
public class Level : MonoBehaviour
{
    public enum Difficulty
    {
        Easy,
        Medium,
        Hard,
        Expert

    }

    public Difficulty LevelSelector;
    // Use this for initialization
    void Start()
    {
        SceneManager.LoadScene((int)LevelSelector);
    }

}
