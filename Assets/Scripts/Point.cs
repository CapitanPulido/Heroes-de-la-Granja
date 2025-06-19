using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Diagnostics;
using CodeMonkey.Utils;

public class Point : MonoBehaviour
{
    [SerializeField] private Camera UiCamera;
    private Vector3 targetPosition;
    private RectTransform pointerRectTransform;


    private void Awake()
    {
        targetPosition = new Vector3(0 , 0);
        pointerRectTransform = transform.Find("Pointer").GetComponent<RectTransform>();
    }
    void Start()
    {
        
    }

    
    void Update()
    {
        Vector3 toPosition = targetPosition;
        Vector3 fromPosition = Camera.main.transform.position;
        fromPosition.z = 0f;
        Vector3 dir = (toPosition - fromPosition).normalized;
        float angle = UtilsClass.GetAngleFromVectorFloat(dir);
        pointerRectTransform.localEulerAngles  = new Vector3(0 ,0  ,angle);

        float borderSize = 50;

        Vector3 targetPositionScreenPoint = Camera.main.WorldToScreenPoint(targetPosition);
        bool isOffScreen = targetPositionScreenPoint.x <= borderSize || targetPositionScreenPoint.x >= Screen.width - borderSize || targetPositionScreenPoint.y <= borderSize || targetPositionScreenPoint.y >= Screen.height - borderSize;
        Debug.Log(isOffScreen + " " + targetPositionScreenPoint);

        if (isOffScreen )
        {
            Vector3 cappedTargetScreenPosition = targetPositionScreenPoint;
            if (cappedTargetScreenPosition.x <= borderSize)
            {
                cappedTargetScreenPosition.x = borderSize;
            }

            if (cappedTargetScreenPosition.x >= Screen.width - borderSize)
            {
                cappedTargetScreenPosition.x = Screen.width - borderSize;
            }

            if (cappedTargetScreenPosition.y <= borderSize)
            {
                cappedTargetScreenPosition.y = borderSize;
            }

            if (cappedTargetScreenPosition.y >= Screen.height - borderSize)
            {
                cappedTargetScreenPosition.y = Screen.height -  borderSize;
            }

            Vector3 pointerWorldPosition = UiCamera.ScreenToWorldPoint(cappedTargetScreenPosition);
            pointerRectTransform.position = pointerWorldPosition;
            pointerRectTransform.localPosition = new Vector3(pointerRectTransform.localPosition.x, pointerRectTransform.localPosition.y, 0f);
        }

        
    }
}
