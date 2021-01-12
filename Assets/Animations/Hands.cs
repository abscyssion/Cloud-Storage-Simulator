using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hands : StateMachineBehaviour
{
    const int minR = 4, maxR = 10;
    int maxReps;
    int reps = 0;

    private void Awake()
    {
        maxReps = Global.Rand(minR, maxR);
    }

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (!Head.playing)
        {
            if (reps >= maxReps)
            {
                reps = 0;
                maxReps = Global.Rand(minR, maxR);
            }
            else
                animator.SetTrigger("Allow");

            reps++;
        }
    }


}
