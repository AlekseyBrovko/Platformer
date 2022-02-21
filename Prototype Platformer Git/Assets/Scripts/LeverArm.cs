using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverArm : MonoBehaviour
{
    private Finish finish;
    private Animator _animator;

    private void Start()
    {
        finish = GameObject.FindGameObjectWithTag("Finish").GetComponent<Finish>();
        _animator = GetComponent<Animator>();
    }

    public void ActivateLeverArm()
    {
        finish.Activate();
        _animator.SetTrigger("activate");
    }
}
