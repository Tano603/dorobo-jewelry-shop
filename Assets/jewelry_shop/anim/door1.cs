using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door1 : MonoBehaviour
{
    //　ドアのアニメーター
    [SerializeField]
    //[Tooltip("自動ドアのアニメーター")]
    private Animator DoorAnimator1;

    /// <summary>
    /// 自動ドア検知エリアに入った時
    /// </summary>
    /// <param name="other"></param>
	private void OnTriggerEnter(Collider other)
    {
        // アニメーションパラメータをtrueにする。(ドアが開く)
        DoorAnimator1.SetBool("leftsidedoor_Open", true);
    }

    /// <summary>
    /// 自動ドア検知エリアを出た時
    /// </summary>
    /// <param name="other"></param>
	private void OnTriggerExit(Collider other)
    {
        // アニメーションパラメータをfalseにする。(ドアが閉まる)
        DoorAnimator1.SetBool("leftsidedoor_Open", false);
    }
}
