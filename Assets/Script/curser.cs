using UnityEngine;

public class curser : MonoBehaviour
{
    public Texture2D mouseThing;
    public Sprite mouseImg;
    public CursorMode Cursormode = CursorMode.Auto;
    void Start()
    {
        Cursor.SetCursor(mouseThing, Vector2.zero, Cursormode);
    }

   
}
