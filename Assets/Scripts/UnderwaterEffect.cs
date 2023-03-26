using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class UnderwaterEffect : MonoBehaviour
{
    public Transform waterPlane;
    public PostProcessProfile normalProfile;
    public PostProcessProfile underwaterProfile;

    private PostProcessVolume postProcessVolume;
    private Camera cam;

    private void Start()
    {
        cam = GetComponent<Camera>();
        postProcessVolume = GetComponent<PostProcessVolume>();
    }

    private void Update()
    {
        if (cam.transform.position.y < waterPlane.position.y)
        {
            postProcessVolume.profile = underwaterProfile;
        }
        else
        {
            postProcessVolume.profile = normalProfile;
        }
    }
}
