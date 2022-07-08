using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WaitSomeTime : MonoBehaviour
{
    public float waitSeconds;
    public string nextScene;
    
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
        yield return new WaitForSeconds(waitSeconds);
        SceneManager.LoadScene(nextScene);
    }
}
