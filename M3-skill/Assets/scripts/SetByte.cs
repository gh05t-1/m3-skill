using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetByte : MonoBehaviour
{
    [SerializeField] Byte myByte;
    [SerializeField] int newValue;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        myByte.SetByte(newValue);
    }
}

