using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[SaveDuringPlay]
[AddComponentMenu("")] // Hide in menu
public class LimitCameraRotation : CinemachineExtension
{
    [Tooltip("Constraints camera rotation")]
    public Vector2 rotationLimits = new Vector2(-10, 10);

    protected override void PostPipelineStageCallback(
        CinemachineVirtualCameraBase vcam,
        CinemachineCore.Stage stage, ref CameraState state, float deltaTime)
    {
        if (stage == CinemachineCore.Stage.Finalize)
        {
            Quaternion currentRotation = state.RawOrientation;

            Vector3 eulerRotation = currentRotation.eulerAngles;
            eulerRotation.x = Mathf.Clamp(eulerRotation.x, rotationLimits.x, rotationLimits.y);

            // Apply the new rotation
            state.RawOrientation = Quaternion.Euler(eulerRotation);
        }
    }
}
