using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door3 : MonoBehaviour
{
    //�@�h�A�̃A�j���[�^�[
    [SerializeField]
    //[Tooltip("�����h�A�̃A�j���[�^�[")]
    private Animator DoorAnimator3;

    /// <summary>
    /// �����h�A���m�G���A�ɓ�������
    /// </summary>
    /// <param name="other"></param>
	private void OnTriggerEnter(Collider other)
    {
        // �A�j���[�V�����p�����[�^��true�ɂ���B(�h�A���J��)
        DoorAnimator3.SetBool("rightfrontdoor_Open", true);
    }

    /// <summary>
    /// �����h�A���m�G���A���o����
    /// </summary>
    /// <param name="other"></param>
	private void OnTriggerExit(Collider other)
    {
        // �A�j���[�V�����p�����[�^��false�ɂ���B(�h�A���܂�)
        DoorAnimator3.SetBool("rightfrontdoor_Open", false);
    }
}
