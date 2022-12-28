using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetBall : MonoBehaviour
{
    [SerializeField] private MainClass _mainClass;
    [SerializeField] private Transform _pointStart;
    private int _layerBall = 3;
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == _layerBall)
        {
            other.transform.position = _pointStart.position;
            _mainClass.IsStart = true;
        }

    }
}
