using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using TMPro;
using UnityEngine;
using Vector2 = UnityEngine.Vector2;

public class MoveText : MonoBehaviour
{
    public TextMeshProUGUI textField;
    public float speedMoving;

    private Vector2 endPosition;
    private Vector2 startPosition;
    
    // Start is called before the first frame update
    void Start()
    {
        startPosition = new Vector2(transform.position.x - 500, transform.position.y);
        endPosition = new Vector2(transform.position.x + 100, transform.position.y);
        
        textField.transform.position = startPosition;
    }

    // Update is called once per frame
    void Update()
    {
        textField.transform.position =
            Vector2.MoveTowards(textField.transform.position, endPosition, Time.deltaTime * speedMoving);
    }
}
