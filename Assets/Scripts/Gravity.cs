using UnityEngine;
using System.Collections;

public enum FallingType
{
    Bomb,
    Grape,
    Banana,
    Apple
}

public class Gravity : MonoBehaviour {

    FallingType ftType;

    public Sprite spBomb, spGrape, spBanana, spApple;

    SpriteRenderer srRender;

    // Use this for initialization
    void Start () {
        if(Random.Range(0.0f, 10.0f) < 1.5f)
        {
            ftType = FallingType.Bomb;
        }
        else
        {
            ftType = FallingType.Apple;
        }
        srRender = this.GetComponent<SpriteRenderer>();

        switch(ftType)
        {
            case FallingType.Bomb:
                srRender.sprite = spBomb;
                break;
            default:
                srRender.sprite = spApple;
                break;
        }
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(new Vector3(0, -Time.deltaTime*4f));
        if(srRender.bounds.Intersects(KeyboardExample.srRenderer.bounds))
        {
            if (ftType == FallingType.Bomb)
            {
                Debug.Log("Boom");
            }
            else
            {
                Debug.Log("Pop");
            }
            Destroy(this.gameObject);
        }

        if (transform.position.y < -3.5)
        {
            Destroy(this.gameObject);
        }
	}
}
