using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossUI : MonoBehaviour
{
    private float BossHpUI;

    public void BossUIHpBar()
    {
        Image BossHpBarImg = GameObject.FindGameObjectWithTag("BossUI").GetComponent<Image>();

        if (BossHpBarImg != null)
        {
            BossHpUI = 40.0f; // ü���� 40���� ����
            BossHpBarImg.fillAmount = BossHpUI / 100.0f; // ü�¿� �°� fillAmount ����
        }
    }
}
