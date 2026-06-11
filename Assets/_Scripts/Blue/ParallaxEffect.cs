using UnityEngine;
using UnityEngine.UIElements;

[RequireComponent(typeof(SpriteRenderer))]
public class ParallaxEffect : MonoBehaviour
{
    [SerializeField]
    // speed of the effect moving
    private float parallaxSpeed;
    private Transform cameraTransform;
    private float startPositionX;
    private float spriteSizeX;

    private void Start()
    {
        cameraTransform = Camera.main.transform;
        startPositionX = transform.position.x;
        spriteSizeX = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    private void Update()
    { 
        // getting relative layer speed to camera
        float relativeDist = cameraTransform.position.x * parallaxSpeed;
        transform.position = new Vector3(startPositionX + relativeDist, transform.position.y, transform.position.x);
        // Loop parallax effect
        // relative camera to the layer
        float relativeCameraDist = cameraTransform.position.x * (1 - parallaxSpeed);
        if (relativeCameraDist > startPositionX + spriteSizeX)
        {
            startPositionX += spriteSizeX;
        }
        else if (relativeCameraDist < startPositionX - spriteSizeX)
        {
            startPositionX -= spriteSizeX;
        }
    }
}
