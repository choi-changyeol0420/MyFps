using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Myfps
{
    public class PutinItem : Interactive
    {
        public Material material;
        private Color color = Color.gray;
        public GameObject fulleye;
        private PlayerState player;
        private void Start()
        {
            fulleye.GetComponent<Renderer>().material.color = color;
            player = PlayerState.Instance;
        }
        protected override void DoAction()
        {
            actionText.text = action;
            if(Input.GetKeyDown(KeyCode.E))
            {
                if(player.HasPuzzleItem(PuzzleKey.RIGHTEYE_KEY) && player.HasPuzzleItem(PuzzleKey.LEFTEYE_KEY))
                {
                    PlayerState.Instance.AcquirePuzzleItem(PuzzleKey.FULLEYE_KEY);
                    fulleye.GetComponent <Renderer>().material = material;
                }
                else
                {
                    return;
                }
                actionText.gameObject.SetActive(false);
                keyText.gameObject.SetActive(false);
            }
        }
    }
}