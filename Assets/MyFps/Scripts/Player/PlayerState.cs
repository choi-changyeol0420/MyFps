using TMPro;
using Unity.VisualScripting;
using UnityEngine;

namespace Myfps
{
    //플레이어의 속성값을 관리하는 (싱글톤, DontDestory )클래스.. ammo
    public class PlayerState : PersistentSingleton<PlayerState>
    {
        #region Varibles
        [SerializeField]private int ammoCount;
        public int AmmoCount
        {
            get { return ammoCount; }
            private set { ammoCount = value; }
        }
        #endregion

        private void Start()
        {
            //속성값/Data 초기화
            AmmoCount = 0;
        }
        public void AddAmmo(int amount)
        {
            AmmoCount += amount;
        }
        public bool UseAmmo(int amount)
        {
            //소지갯수 체크
            if(AmmoCount < amount)
            {
                Debug.Log("You need to reload");
                return false;   //사용량보다 부족하다
            }
            AmmoCount -= amount;
            return true;
        }
    }
}