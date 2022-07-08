using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Loader : MonoBehaviour
{
    public string loadLevel;
    public Slider slider;
    public TextMeshProUGUI statusText; 

    // Start is called before the first frame update
    void Start()
    
    {
        StartCoroutine(Waiter());
    }

    IEnumerator Waiter()
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(loadLevel);
        asyncLoad.allowSceneActivation = false;
        
        while (!asyncLoad.isDone)
        {
            statusText.text = (asyncLoad.progress * 100f) + "%";
            slider.value = asyncLoad.progress;


            if (asyncLoad.progress >= 0.9f && !asyncLoad.allowSceneActivation)
            {
                yield return new WaitForSeconds(1);
                asyncLoad.allowSceneActivation = true;
            }

            yield return null;
        }

    }

    // Update is called once per frame
    void Update()
    {
    }
}