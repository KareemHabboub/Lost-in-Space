using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorial : MonoBehaviour
{
    public Sprite tut2;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (ReadyButton.ready)
            this.gameObject.GetComponent<SpriteRenderer>().sprite = tut2;
    }
}
