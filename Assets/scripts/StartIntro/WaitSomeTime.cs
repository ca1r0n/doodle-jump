using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WaitSomeTime : MonoBehaviour
{
    public float waitSeconds;
    public string nextScene;
    public TextMeshProUGUI textField;
    public Slider sliderField;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Waiter());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Waiter()
    {
        AsyncOperation async = SceneManager.LoadSceneAsync(nextScene);
        async.allowSceneActivation = false;

        while (!async.isDone)
        {
            textField.text = async.progress * 100 + "%";
            sliderField.value = async.progress;

            if (async.progress >= 0.9f)
            {
                yield return new WaitForSeconds(waitSeconds);
                async.allowSceneActivation = true;
                break;
            }
            
            yield return null;
        }
    }
}
