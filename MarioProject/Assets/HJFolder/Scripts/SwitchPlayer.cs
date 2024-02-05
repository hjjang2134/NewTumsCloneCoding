using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchPlayer : MonoBehaviour
{
    public GameObject marioPrefab; // 마리오 프리팹
    public GameObject catmarioPrefab; // 고양이마리오 

    public GameObject currentCharacter = null; // 현재 캐릭터



    private void Start()
    {
        
    }


    // 마리오로 캐릭터 전환
    public void SwitchToMario()
    {
        // 이전 캐릭터가 있으면 삭제
        if (currentCharacter != null)
            Destroy(currentCharacter);

        // 마리오 프리팹을 현재 위치에 생성
        currentCharacter = Instantiate(marioPrefab, transform.position, transform.rotation);
    }

    // 고양이마리오로 캐릭터 전환
    public void SwitchToCat()
    {
        // 이전 캐릭터가 있으면 삭제
        if (currentCharacter != null)
            Destroy(currentCharacter);

        // 루이지 프리팹을 현재 위치에 생성
        currentCharacter = Instantiate(catmarioPrefab, transform.position, transform.rotation);
    }
}
