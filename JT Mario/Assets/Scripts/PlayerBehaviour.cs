using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public SpriteRenderer bigRenderer;
    public SpriteRenderer smallRenderer;
    private Animator smallAnimator;
    public bool big;


    // Start is called before the first frame update
    public void Start()
    {
        smallAnimator = smallRenderer.gameObject.GetComponent<Animator>();
        big = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Hit()
    {

    }

    private void Shrink()
    {

    }

    private void Death()
    {

    }
   // private IEnumerator ChangeSize()
   // {

   // }
}
