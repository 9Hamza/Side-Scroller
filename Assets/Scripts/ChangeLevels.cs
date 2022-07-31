using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // To be able to access scene assets in Unity

public class ChangeLevels : MonoBehaviour
{

    [SerializeField] private string level1, level2;
    [SerializeField] private KeyCode one, two;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(one))
            SceneManager.LoadScene(level1);

        if (Input.GetKeyDown(two))
            SceneManager.LoadScene(level2);
    }
}
