using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    private UnityEngine.UI.Button btn;
    public string nextScene;
    
    // Start is called before the first frame update
    void Start()
    {
        btn = GetComponent<UnityEngine.UI.Button>();
        btn.onClick.AddListener(OnClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        Debug.Log("Go to scene: " + nextScene);
        StartCoroutine(Darking.darking.NextScene(nextScene));
    }
}
