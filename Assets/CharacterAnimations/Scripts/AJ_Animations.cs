using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class AJ_Animations : MonoBehaviour {
    [SerializeField] private Animator animator;
    private static readonly int Die = Animator.StringToHash("Die");
    private static readonly int IsDancing = Animator.StringToHash("IsDancing");
    

    private void Update() {
        if (Input.GetKeyDown(KeyCode.Alpha1)) {
            animator.SetBool(IsDancing, true);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2)) {
            animator.SetTrigger(Die);
            animator.SetBool(IsDancing, false);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3)) {
            animator.SetBool(IsDancing, false);
        }
    }
}
