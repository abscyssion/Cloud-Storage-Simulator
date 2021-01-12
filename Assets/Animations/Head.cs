using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Head : StateMachineBehaviour
{
    public static bool playing;

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if(Global.Roulette(0.10f))
        {
            animator.SetTrigger("Play");
            playing = true;
        }
    }
}
