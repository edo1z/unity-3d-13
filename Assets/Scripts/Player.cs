using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    private Animator m_Animator;

    private void Awake()
    {
        m_Animator = GetComponentInChildren<Animator>();
    }

    public void OnWalk(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Canceled)
        {
            m_Animator.SetFloat("MoveSpeed", 0f);
        }
        else
        {
            Debug.Log("Walk! " + context.phase);
            m_Animator.SetFloat("MoveSpeed", 1f);
        }
    }

    public void OnRun(InputAction.CallbackContext context)
    {
        Debug.Log("Run!");
    }

    public void OnPunch(InputAction.CallbackContext context)
    {
        Debug.Log("Punch!");
        m_Animator.Play("Punch");
    }

    public void OnKick(InputAction.CallbackContext context)
    {
        Debug.Log("Kick!");
        m_Animator.Play("Kick");
    }
}
