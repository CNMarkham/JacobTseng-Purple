using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ENEMY : MonoBehaviour
{
    private Animator animator;

    // Start is called before the first frame update
    public float xSpace;
    public float xOffset;
    void Start()
    {
        animator = GetComponent<Animator>();
    }
}
