using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blocked : MonoBehaviour
{
    public GameObject item;
    public int maxHits = -1;
    public Sprite emptyBlock;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponentInChildren<Animator>();
    }

    public void hit()
    {
        if (maxHits <= 0)
        {
            return;
        }
        animator.SetTrigger("hit");
        maxHits--;
        if (item != null)
        {
            Instantiate(item, transform);
        }

        if (maxHits == 0)
        {
            SpriteRenderer spriteRenderer = GetComponentInChildren<SpriteRenderer>();
            spriteRenderer.sprite = emptyBlock;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
