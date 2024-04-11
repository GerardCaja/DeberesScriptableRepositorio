using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextoManager : MonoBehaviour
{
    public Text textLine1;
    public Text textLine2;
    public Text textLine3;
    public Text textLine4;
    public Text textLineButton1;
    public Text textLineButton2;
    public Text textLineButton3;

    public void UpdateText(Texto textObject)
    {
        textLine1.text = textObject.texto1;
        textLine2.text = textObject.texto2;
        textLine3.text = textObject.texto3;
        textLine4.text = textObject.texto4;
        textLineButton1.text = textObject.textoBoton1;
        textLineButton2.text = textObject.textoBoton2;
        textLineButton3.text = textObject.textoBoton3;
    }
}
