using UnityEngine;
using System.Collections;

public class FlameBarController : MonoBehaviour {

    Animator animator;
    TorchScript torch;
	// Use this for initialization
	void Start () 
    {
        animator = GetComponent<Animator>();
        torch = GameObject.FindGameObjectWithTag("Player").GetComponent<TorchScript>();
	}
	
	// Update is called once per frame
	void Update () 
    {
        //checking the name of the animation that is playing
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("FlameBar"))
        {
            //animator.ForceStateNormalizedTime((100 - torch.torchHealth)/100);
            animator.Play(0, -1, (100 - torch.torchHealth) / 100);
        }

        if (animator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1 && animator.GetCurrentAnimatorStateInfo(0).IsName("FlameBarFill"))
        {
            animator.SetBool("isFilling",false);
        }
	}
}
