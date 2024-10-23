using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Myfps
{
    public class Breakable : MonoBehaviour, IDamageable
    {
        public GameObject Barrel;
        private float Health;
        private float MaxHealth = 5;
        private bool isDie = false;
        public bool isKey = false;
        public GameObject Key;

        private void Start()
        {
            Health = MaxHealth;
        }
        public void TakeDamage(float damage)
        {
            Health -= damage;

            if (Health <= 0 && !isDie)
            {
                Die();
                if (!isKey) return;
                if(isKey)
                {
                    Key.SetActive(true);
                }
            }
        }
        void Die()
        {
            isDie = true;
            Destroy(gameObject);
            GameObject Barrel_B = Instantiate(Barrel, transform.position, Quaternion.identity);
            AudioManager.Instance.Play("PotterySmash");
        }
    }
}