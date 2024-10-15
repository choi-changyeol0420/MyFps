using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Myfps
{
    public class PistolShoot : MonoBehaviour
    {
        #region Variables
        private Animator animator;
        public ParticleSystem muzzle;
        public AudioSource pistolshot;

        //public Transform pistolcamera;
        public Transform firePoint;

        //연사 딜레이
        private float fireDelay = 0.5f;
        private bool isFire =false;
        public EnemyController enemyController;

        //pistol 공격력
        private float damage = 5;
        #endregion
        // Start is called before the first frame update
        void Start()
        {
            //참조
            animator = GetComponent<Animator>();
        }

        // Update is called once per frame
        void Update()
        {
            if(Input.GetButtonDown("Fire") && !isFire)
            {
                StartCoroutine(Shoot());
            }
        }
        IEnumerator Shoot()
        {
            isFire = true;
            float maxDistance = 100f;
            RaycastHit hit;
            if(Physics.Raycast(firePoint.position, firePoint.TransformDirection(Vector3.forward), out hit, maxDistance))
            {
                Debug.Log("Shoot");
                enemyController.TakeDamage(damage);

            }
            //슛 효과 - VFS, SFX
            muzzle.gameObject.SetActive(true);
            muzzle.Play();
            animator.SetTrigger("Fire");

            pistolshot.Play();

            yield return new WaitForSeconds(fireDelay);
            muzzle.Stop();
            muzzle.gameObject.SetActive(false);

            isFire = false;
        }
        //gizmo 총
        private void OnDrawGizmosSelected()
        {
            float maxDistance = 100f;
            RaycastHit hit;
            bool isHit = Physics.Raycast(firePoint.position, firePoint.TransformDirection(Vector3.forward), out hit, maxDistance);
            Gizmos.color = Color.red;
            if (isHit)
            {
                Gizmos.DrawRay(firePoint.position, firePoint.forward * hit.distance);
            }
            else
            {
                Gizmos.DrawRay(firePoint.position, firePoint.forward * maxDistance);
            }

        }
    }
}