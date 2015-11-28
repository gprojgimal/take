using UnityEngine;
using System.Collections;

public class KeyboardExample : MonoBehaviour
{
    public static SpriteRenderer srRenderer;


    // Use this for initialization
    void Start()
    {
        srRenderer = this.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow) && transform.position.x > -5.0f)
        {
            transform.Translate(new Vector3(-0.2f, 0, 0));
        }
        else if (Input.GetKey(KeyCode.RightArrow) && transform.position.x < 5.0f)
        {
            transform.Translate(new Vector3(0.2f, 0, 0));
        }
        //Debug.Log(transform.position);
    }
}
