using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ArrowName", menuName = "ScriptableObjects/ArrowData", order = 0)]

public class ArrowData : ScriptableObject
{
    public string arrowName = "Default Arrow";
    public float baseDamage = 10f;
    public float knockback = 0f;
    public Sprite icon;
    public GameObject prefab; // ȭ�� ������ (�ɼ�)
    public AudioClip hitSound; // �ǰ� ���� (�ɼ�)
    // ���� �߰�: �ӵ� ����, ����Ʈ, �����̻� ��
}
