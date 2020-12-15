using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSprite : MonoBehaviour
{

    public Sprite happywizard;
    public Sprite hurtwizard;

    // Start is called before the first frame update
   
    public void Happy()
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = happyface;
    }

    // Update is called once per frame
    public void Angry()
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = angryface;
    }
}