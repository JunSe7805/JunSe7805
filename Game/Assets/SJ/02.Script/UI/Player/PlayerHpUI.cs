using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHpUI : MonoBehaviour
{
    // ü��
    private float _Hp;

    public void PlayerHpBar()
    {
        Image HpBarImg = GameObject.FindGameObjectsWithTag("State")[0].GetComponent<Image>();

        if (HpBarImg != null)
        {
            _Hp = 40.0f; // ü���� 40���� ����
            HpBarImg.fillAmount = _Hp / 100.0f; // ü�¿� �°� fillAmount ����
        }
    }
}
