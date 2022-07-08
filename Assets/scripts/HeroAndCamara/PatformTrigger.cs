using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatformTrigger : MonoBehaviour
{

    [SerializeField] private GameObject Hero;
    move hero_script;
    
    void Start()
    {
        hero_script = Hero.GetComponent<move>();
    }
    
    void Update()
    {
        CheckPos(Hero.transform);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        hero_script.CheckTrigger = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        hero_script.CheckTrigger = false;
    }
    private void CheckPos(Transform man)
    {
        if (man.transform.position.y < transform.position.y) 
        {
            GetComponent<Collider2D>().isTrigger = true;
        }
        else
        {
            GetComponent<Collider2D>().isTrigger = false;
        }
    }
}
