using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdlePyramidBehaviour : StateMachineBehaviour
{
    private int rand;
    public int maxTime;
    public int minTime;
    private float timer;

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        AdvancedAI.firstAttack = true;
        AdvancedAI.shootAttack = false;
        AdvancedAI.fallingAttack = false;
        rand = Random.Range(0,2);
        timer = Random.Range(minTime, maxTime);
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (timer <= 0)
        {
            if (rand == 0)
            {
                AdvancedAI.firstAttack= false;
                AdvancedAI.shootAttack = true;
                AdvancedAI.fallingAttack = false;
            }

            else if(rand == 1)
            {
                AdvancedAI.firstAttack= false;
                AdvancedAI.shootAttack = false;
                AdvancedAI.fallingAttack = true;
            }
        }

        else if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        
    }

  

    // OnStateMove is called right after Animator.OnAnimatorMove()
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that processes and affects root motion
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}
}
