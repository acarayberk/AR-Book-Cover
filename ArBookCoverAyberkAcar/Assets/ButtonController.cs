using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using TMPro;

public class ButtonController : MonoBehaviour
{
    public TextMeshPro tmp;
    public VirtualButtonBehaviour Vb;
    // Start is called before the first frame update
    void Start()
    {
        Vb.RegisterOnButtonPressed(OnButtonPressed);
        Vb.RegisterOnButtonReleased(OnButtonReleased);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        tmp.text = "A compelling story that takes place in 1920s, depicting the American Dream and the Jazz Age. A classic and must-read.";
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        tmp.text = "Title:\nThe Great Gatsby\nAuthor:\nF.Scott Fitzgerald\nPage Count: 180\nPublished in: 1925";
    }
}

