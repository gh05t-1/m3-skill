using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bit : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    public bool state = true;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (state)
        {
            spriteRenderer.color = Color.black;
        }
        else
        {
            spriteRenderer.color = Color.red;
        }

    }
    private void OnMouseUp()
    {
        state = !state;
    }
}
