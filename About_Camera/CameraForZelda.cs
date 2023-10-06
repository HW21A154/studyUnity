using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraForZelda : MonoBehaviour
{
//ウルトラハンドを使用した時のカメラの変化
	// バーチャルカメラ
    [SerializeField] private CinemachineVirtualCamera virtualCamera;

    CinemachineFramingTransposer ViewCameraTransposer;

    bool onUltraHand = false;


    void Start()
    {
        ViewCameraTransposer = virtualCamera.GetCinemachineComponent<CinemachineFramingTransposer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (onUltraHand)
        {
            UltraHand();
            ViewCameraTransposer.m_ScreenX = Mathf.Lerp(ViewCameraTransposer.m_ScreenX, 0.4f, 0.1f);
            ViewCameraTransposer.m_ScreenY = Mathf.Lerp(ViewCameraTransposer.m_ScreenY, 0.6f, 0.1f);
        }else
        {
            ViewCameraTransposer.m_ScreenX = Mathf.Lerp(ViewCameraTransposer.m_ScreenX, 0.5f, 0.1f);
            ViewCameraTransposer.m_ScreenY = Mathf.Lerp(ViewCameraTransposer.m_ScreenY, 0.5f, 0.1f);
        }
        
    }
    public void OnUltraHand(InputAction.CallbackContext context)
    {
        bool i = true;
        if (!onUltraHand && i)
        {
            onUltraHand = true;
            i = false;
        }
        if (onUltraHand && i)
        {
            onUltraHand = false;
        }
    }

    void UltraHand()
    {
        Debug.Log("ウルトラハンド使用中");
    }
}


