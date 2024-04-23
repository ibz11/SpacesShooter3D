using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class limitPlayerSpace : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float _rightBoundary = 15f;
        if (transform.position.x >= _rightBoundary)
        {
            transform.position = new Vector3(_rightBoundary, transform.position.y, 10f);
        }

    } }



