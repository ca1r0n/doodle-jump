using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Darking : MonoBehaviour
{
    public static Darking darking;
    public float fadeSpeed;
    private Image image;
    
    // Start is called before the first frame update
    void Start()
    {
        if (darking == null)
        {
            darking = this;
            image = darking.GetComponent<UnityEngine.UI.Image>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator NextScene(string sceneName)
    {
        AsyncOperation async = SceneManager.LoadSceneAsync(sceneName);
        async.allowSceneActivation = false;

        while (image.color.a < 1)
        {
            Color color = image.color;
            color.a += Time.deltaTime * fadeSpeed;
            image.color = color;

            yield return new WaitForSeconds(0.01f);
        }
    }
}
