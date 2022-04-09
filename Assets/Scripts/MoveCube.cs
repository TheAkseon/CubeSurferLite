using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour 
{
    private float _minXposition = -6f;
    private float _maxXposition = 6f;
    private float _speed = 5f;
    private bool _needA = true;
    private bool _needB = false;

    private void Update()
    {
        if (_needA)
        {
            transform.Translate(_speed * Time.deltaTime, 0f, 0f);
            if (transform.position.x >= _maxXposition)
            {
                _needA = false;
                _needB = true;
            }
        }

        if (_needB)
        {
            transform.Translate(-_speed * Time.deltaTime, 0f, 0f);
            if (transform.position.x <= _minXposition)
            {
                _needB = false;
                _needA = true;
            }
        }
    }
}
