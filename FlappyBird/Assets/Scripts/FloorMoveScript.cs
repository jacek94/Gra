﻿using UnityEngine;
using System.Collections;

public class FloorMoveScript : MonoBehaviour
{


    void Start()
    {

    }

    // aktualizowanie pozycji   jeden  raz  na  klatkę 
    void Update()
    {
        if (transform.localPosition.x < -3.9f)
        {
            transform.localPosition = new Vector3(0, transform.localPosition.y, transform.localPosition.z);
        }
        transform.Translate(-Time.deltaTime, 0, 0);
    }


}
