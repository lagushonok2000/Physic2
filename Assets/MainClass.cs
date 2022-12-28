using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainClass : MonoBehaviour
{
    [SerializeField] private Animator _screw;
    [SerializeField] private Rigidbody _sphere;
    [SerializeField] private float _force;
    public bool IsStart = true;
    private void StartBall()
    {
        _screw.SetTrigger("start");
        _sphere.AddForce(Vector3.back * _force, ForceMode.Impulse);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && IsStart)
        {
            StartBall();
            IsStart = false;
        }
    }

}
