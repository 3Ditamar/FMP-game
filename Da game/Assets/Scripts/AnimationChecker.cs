using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationChecker : MonoBehaviour
{
    private Animator _animator;
    private int _idleAnimationHash;
	public GameObject Player;
	
	//flags to save last loc when idle
	private float flagX;
	private float flagY;

    private void Awake()
    {
        // Get the Animator component on this GameObject
        _animator = GetComponent<Animator>();

        // Get the hash of the idle animation state
        _idleAnimationHash = Animator.StringToHash("idle animation");
    }

    private void Update()
    {
        // Check if the current state is the idle animation state
        if (_animator.GetCurrentAnimatorStateInfo(0).fullPathHash == _idleAnimationHash)
        {
            Debug.Log("Animation is idle!");
       
	   
			flagX = Player.transform.position.x;
			flagY = Player.transform.position.y;
		}
    }
}