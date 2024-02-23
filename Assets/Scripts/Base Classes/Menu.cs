using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    private float currentTime;
    public float introTime = 8;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        if(currentTime >= introTime)
        {
            SceneSwitch(1);
        }
    }

    public void SceneSwitch(int scene)
    {
        SceneManager.LoadScene(scene);
    }
}
