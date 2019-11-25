using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeImgBtn : MonoBehaviour
{
    public Image imageToChange;
    public Sprite Img1;
    public Sprite Img2;
    public Sprite Img3;
    public Sprite Img4;

    void start()
    {
        imageToChange = GetComponent<Image>();
    }

    public void ChangeImageBtnJugar()
    {
        imageToChange.sprite = Img1;
    }

    public void ChangeImageBtnPersonajes()
    {
        imageToChange.sprite = Img2;
    }

    public void ChangeImageBtnCreditos()
    {
        imageToChange.sprite = Img3;
    }

    public void ChangeImageBtnSalir()
    {
        imageToChange.sprite = Img4;
    }







}

