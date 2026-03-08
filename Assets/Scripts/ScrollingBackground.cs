using UnityEngine;

public class ScrollingBackground : MonoBehaviour
{
    public Renderer bgRender;
    public float scrollSpeed;
    // Update is called once per frame
    void Update()
    {
        bgRender.material.mainTextureOffset = new Vector2(0,Time.time * scrollSpeed);
    }
}
