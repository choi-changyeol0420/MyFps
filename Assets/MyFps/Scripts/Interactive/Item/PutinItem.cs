using UnityEngine;

namespace Myfps
{
    public class PutinItem : Interactive
    {
        public GameObject fakefulleye;
        public GameObject realfulleye;
        public GameObject fakewall;
        public GameObject exitwall;
        private Animator animator;
        private PlayerState player;
        private void Start()
        {
            animator = exitwall.GetComponent<Animator>();
            player = PlayerState.Instance;
        }
        private void Update()
        {
            if(player.HasPuzzleItem(PuzzleKey.LEFTEYE_KEY)
                    && player.HasPuzzleItem(PuzzleKey.RIGHTEYE_KEY))
            {
                fakewall.GetComponent<Renderer>().enabled = false;
                exitwall.SetActive(true);
            }
        }
        protected override void DoAction()
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (player.HasPuzzleItem(PuzzleKey.LEFTEYE_KEY)
                    && player.HasPuzzleItem(PuzzleKey.RIGHTEYE_KEY))
                {
                    fakefulleye.SetActive(false);
                    realfulleye.SetActive(true);
                    animator.SetBool("IsOpen", true);
                    fakewall.GetComponent<BoxCollider>().isTrigger = true;
                }
            }
        }
    }
}