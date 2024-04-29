using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMpUI : MonoBehaviour
{
    // ����
    private float _Mp;

    public void PlayerMpBar()
    {
        Image MpBarImg = GameObject.FindGameObjectsWithTag("State")[1].GetComponent<Image>();

        if (MpBarImg != null)
        {
            _Mp = 30.0f; // ü���� 40���� ����
            MpBarImg.fillAmount = _Mp / 100.0f; // ü�¿� �°� fillAmount ����
        }
    }
}
