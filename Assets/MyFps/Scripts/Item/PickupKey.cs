using UnityEngine;

namespace Myfps
{
    public class PickupKey : Interactive
    {
        protected override void DoAction()
        {
            keyText.text = "[E]";
            actionText.text = "Pick up Key";
            if(Input.GetKeyDown(KeyCode.E))
            {
                PlayerState.Instance.AcquirePuzzleItem(PuzzleKey.ROOM01_KEY);
                Destroy(gameObject);
                keyText.text = "";
                actionText.text = "";
                extraCross.SetActive(false);
            }
        }
    }
}