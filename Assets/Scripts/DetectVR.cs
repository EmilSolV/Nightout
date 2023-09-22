using UnityEngine;
using UnityEngine.XR.Management;

public class DetectVR : MonoBehaviour
{
    public bool startInVR = true;
    public GameObject xrOrigin;
    public GameObject desktopCharacter;

    void Start()
    {
        if (startInVR)
        {
            var xrSettings = XRGeneralSettings.Instance;

            if (xrSettings == null)
            {
                Debug.Log("XRGeneral is null");
            }

            var xrManager = xrSettings.Manager;

            if (xrManager == null)
            {
                Debug.Log("XRManager is null");
            }

            var xrLoader = xrManager.activeLoader;

            if (xrLoader == null)
            {
                Debug.Log("XRLoader is null");
                ToggleVRCamera(false);
                return;
            }

            Debug.Log("XRLoader is not null");
            ToggleVRCamera(true);
        }
        else {
            ToggleVRCamera(false);
        }
    }

    void ToggleVRCamera(bool toggle)
    {
        xrOrigin.SetActive(toggle);
        desktopCharacter.SetActive(!toggle);
    }
}
