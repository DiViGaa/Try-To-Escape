using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPosition : MonoBehaviour
{
    public Animator cameraAnimator;

    private void Awake()
    {
        cameraAnimator = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Animator>();
    }
    public void MoveCameraToSelect()
    {
        cameraAnimator.SetBool("SelectState", true);
    }

    public void MoveCameraToSetting()
    {
        cameraAnimator.SetBool("SettingState", true);
    }

    public void MoveCameraToStart()
    {
        cameraAnimator.SetBool("SelectState", false);
        cameraAnimator.SetBool("SettingState", false);

    }
}
