using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] private Vector2 RefResolution;

    private void Start()
    {
        float refAspect = RefResolution.x / RefResolution.y;
        float scaleMultiplier = refAspect / UnityEngine.Camera.main.aspect;
        float newSize = UnityEngine.Camera.main.orthographicSize * scaleMultiplier;

        UnityEngine.Camera.main.orthographicSize = newSize;



    }
}
