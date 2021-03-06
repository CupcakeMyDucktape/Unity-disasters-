using System;
using UnityEngine;


namespace UnityStandardAssets.Utility
{
    public class FollowTarget : MonoBehaviour
    {
        public Transform target;
        public Vector3 offset = new Vector3(0f, 7.5f, 0f);


        private void LateUpdate()
        {
            //transform.position = Vector3.Lerp(transform.position, target.position, 0.01f);
            transform.position = target.position + offset;
        }
    }
}
