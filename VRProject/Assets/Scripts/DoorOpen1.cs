﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void transformDoor()
    {
        transform.rotation = Quaternion.Euler(90, -75, 180);
        //transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(90, -75, 180), 2f * Time.deltaTime);
        GetComponentInParent<SentenceAssembler>().GetSentence(0);
    }
}
