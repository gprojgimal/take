using UnityEngine;
using System.Collections;

public enum FallingType
{
    Bomb,
    Tomato,
    Orange,
    Strawberry,
    Banana,
    Peach,
    Apple,
    Apricot,
    Cherry
}

public class Gravity : MonoBehaviour {

    FallingType ftType;

    public Sprite spBomb, spTomato, spOrange, spStraw, spBanana, spPeach, spApple, spApricot, spCherry;

    SpriteRenderer srRender;

    // Use this for initialization
    void Start () {
        if(Random.Range(0.0f, 10.0f) < 1.5f)
        {
            ftType = FallingType.Bomb;
        }
        else
        {
            ftType = (FallingType)Mathf.Round(Random.Range(1.0f, 8.0f));
        }
        srRender = this.GetComponent<SpriteRenderer>();

        switch(ftType)
        {
            case FallingType.Bomb:
                srRender.sprite = spBomb;
                break;
            case FallingType.Tomato:
                srRender.sprite = spTomato;
                break;
            case FallingType.Orange:
                srRender.sprite = spOrange;
                break;
            case FallingType.Strawberry:
                srRender.sprite = spStraw;
                break;
            case FallingType.Banana:
                srRender.sprite = spBanana;
                break;
            case FallingType.Peach:
                srRender.sprite = spPeach;
                break;
            case FallingType.Apple:
                srRender.sprite = spApple;
                break;
            case FallingType.Apricot:
                srRender.sprite = spApricot;
                break;
            case FallingType.Cherry:
                srRender.sprite = spCherry;
                break;
            default:
                srRender.sprite = spApple;
                break;
        }
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(new Vector3(0, -0.1f));
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
