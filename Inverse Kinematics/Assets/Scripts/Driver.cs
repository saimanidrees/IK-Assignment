using System;
using UnityEngine;
public class Driver : MonoBehaviour
{
    [SerializeField]protected Animator animator;
    public IkPoint[] ikPoints;
    [Serializable]
    public class IkPoint
    {
        public Transform ikTransform;
        public float weightValue;
    }
    private void OnAnimatorIK(int layerIndex)
    {
        if (!animator)
            return;
        if (ikPoints[0].ikTransform)
        {
            animator.SetIKPosition(AvatarIKGoal.RightHand, ikPoints[0].ikTransform.position);
            animator.SetIKRotation(AvatarIKGoal.RightHand, ikPoints[0].ikTransform.rotation);
            animator.SetIKPositionWeight(AvatarIKGoal.RightHand, ikPoints[0].weightValue);
            animator.SetIKRotationWeight(AvatarIKGoal.RightHand, ikPoints[0].weightValue);
        }
        if (ikPoints[1].ikTransform)
        {
            animator.SetIKHintPosition(AvatarIKHint.RightElbow, ikPoints[1].ikTransform.position);
            animator.SetIKHintPositionWeight(AvatarIKHint.RightElbow, ikPoints[1].weightValue);
        }
        if (ikPoints[2].ikTransform)
        {
            animator.SetIKPosition(AvatarIKGoal.LeftHand, ikPoints[2].ikTransform.position);
            animator.SetIKRotation(AvatarIKGoal.LeftHand, ikPoints[2].ikTransform.rotation);
            animator.SetIKPositionWeight(AvatarIKGoal.LeftHand, ikPoints[2].weightValue);
            animator.SetIKRotationWeight(AvatarIKGoal.LeftHand, ikPoints[2].weightValue);
        }
        if (ikPoints[3].ikTransform)
        {
            animator.SetIKHintPosition(AvatarIKHint.LeftElbow, ikPoints[3].ikTransform.position);
            animator.SetIKHintPositionWeight(AvatarIKHint.LeftElbow, ikPoints[3].weightValue);
        }
    }
}