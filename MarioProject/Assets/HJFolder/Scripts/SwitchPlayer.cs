using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchPlayer : MonoBehaviour
{
    public GameObject marioPrefab; // ������ ������
    public GameObject catmarioPrefab; // ����̸����� 

    public GameObject currentCharacter = null; // ���� ĳ����



    private void Start()
    {
        
    }


    // �������� ĳ���� ��ȯ
    public void SwitchToMario()
    {
        // ���� ĳ���Ͱ� ������ ����
        if (currentCharacter != null)
            Destroy(currentCharacter);

        // ������ �������� ���� ��ġ�� ����
        currentCharacter = Instantiate(marioPrefab, transform.position, transform.rotation);
    }

    // ����̸������� ĳ���� ��ȯ
    public void SwitchToCat()
    {
        // ���� ĳ���Ͱ� ������ ����
        if (currentCharacter != null)
            Destroy(currentCharacter);

        // ������ �������� ���� ��ġ�� ����
        currentCharacter = Instantiate(catmarioPrefab, transform.position, transform.rotation);
    }
}
