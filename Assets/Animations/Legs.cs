using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Legs : StateMachineBehaviour
{
    const int minR = 2, maxR = 3;
    int maxReps;
    int reps = 0;

    private void Awake()
    {
        maxReps = Global.Rand(minR, maxR);
    }

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
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
