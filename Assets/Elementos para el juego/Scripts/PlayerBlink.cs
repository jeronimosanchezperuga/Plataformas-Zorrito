using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBlink : MonoBehaviour
{
    SpriteRenderer renderer;
    Color damageColor = Color.red;
    Color normalColor;
    // Start is called before the first frame update

    private void Awake()
    {
        renderer = GetComponent<SpriteRenderer>();
    }
    void Start()
    {
        normalColor = renderer.color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Blink()
    {
        Invoke("EnableBlink", 0);
        Invoke("DisableBlink", 0.2f);
    }

    void EnableBlink()
    {
        renderer.color = damageColor;
    }
    void DisableBlink()
    {
        renderer.color = normalColor;
    }
}
