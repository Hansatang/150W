using UnityEngine;

public class BackgroundHandler : MonoBehaviour
{
    [SerializeField] private Camera mainCamera;
    [SerializeField] private GameObject space;

    // Original background object dimensions
    private float _backgroundOriginalSizeX;
    private float _backgroundOriginalSizeY;

    private float _cameraOffsetX;
    private float _cameraOffsetY;

    void Start()
    {
        // Original Background Sizes
        SpriteRenderer sr = space.GetComponent<SpriteRenderer>();
        var originalSize = sr.size;
        _backgroundOriginalSizeX = originalSize.x;
        _backgroundOriginalSizeY = originalSize.y;
    }

    void Update()
    {
        // When the background reaches a shift equal to the original size in any direction, we return it to the origin exactly in this direction

        if (mainCamera.transform.position.x + _cameraOffsetX >= _backgroundOriginalSizeX)
        {
            _cameraOffsetX -= _backgroundOriginalSizeX;
            space.transform.Translate(_backgroundOriginalSizeX, 0, 0);
        }

        if (mainCamera.transform.position.x + _cameraOffsetX <= -_backgroundOriginalSizeX)
        {
            _cameraOffsetX += _backgroundOriginalSizeX;
            space.transform.Translate(-_backgroundOriginalSizeX, 0, 0);
        }

        if (mainCamera.transform.position.y + _cameraOffsetY >= _backgroundOriginalSizeY)
        {
            _cameraOffsetY -= _backgroundOriginalSizeY;
            space.transform.Translate(0, +_backgroundOriginalSizeY, 0);
        }

        if (mainCamera.transform.position.y + _cameraOffsetY <= -_backgroundOriginalSizeY)
        {
            _cameraOffsetY += _backgroundOriginalSizeY;
            space.transform.Translate(0, -_backgroundOriginalSizeY, 0);
        }
    }
}