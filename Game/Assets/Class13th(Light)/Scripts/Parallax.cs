using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Parallax : MonoBehaviour
{
    [SerializeField] Rect rect;
    [SerializeField] RawImage rawImage; // �����̴� �̹��� ó�� �ұ�

    [SerializeField] float speed = 0.25f;

    private void Update()
    {
        rect = rawImage.uvRect;
        rect.x += speed * Time.deltaTime;

        rawImage.uvRect = rect;
    }


}
