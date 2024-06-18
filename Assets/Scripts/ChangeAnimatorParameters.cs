using UnityEngine;

public class ChangeAnimatorParameters : MonoBehaviour
{
    [SerializeField] private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    public void ChangeParameters(string nameOfParameters)
    {
        animator.SetBool(nameOfParameters, !animator.GetBool(nameOfParameters));
    }
}
