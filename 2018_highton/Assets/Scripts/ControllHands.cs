using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControllHands : MonoBehaviour {

    public GameObject bullet;
    //
    public Transform firePos;
    //
    public GameObject Impact;
    //
    public ImpactInfo[] impactElemets = new ImpactInfo[0];
    //
    public float BulletDistance = 100;
    //
    private bool canShoot = true;
    //
    private int shotCnt = 0;
    //
    public Canvas score;
    //
    public Text hitScore;
    //

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Fire();
            RaycastHit hit;
            var ray = new Ray(transform.position, transform.forward);
            if (Physics.Raycast(ray, out hit, BulletDistance))
            {
                var effect = GetImpactEffect(hit.transform.gameObject);
                if (effect == null)
                    return;
                var effectIstance = Instantiate(effect, hit.point, new Quaternion()) as GameObject;
                Impact.SetActive(false);
                Impact.SetActive(true);
                effectIstance.transform.LookAt(hit.point + hit.normal);
                Destroy(effectIstance, 4);
            }
        }
        CheckCanShoot();
    }

    private void Fire()
    {
        if (canShoot)
        {
            Instantiate(bullet, firePos.position, firePos.rotation);
            SoundManager.instance.PlayFireSound();
            shotCnt++;
        }
        else
            return;

    }
    private void CheckCanShoot()
    {
        if (shotCnt > 5)
        {
            canShoot = false;
            score.transform.gameObject.SetActive(true);
            hitScore.text = BulletManager.instance.hitCnt.ToString();
        }
        else
            return;
    }

    [System.Serializable]
    public class ImpactInfo
    {
        public MaterialType.MaterialTypeEnum MaterialType;
        public GameObject ImpactEffect;
    }

    GameObject GetImpactEffect(GameObject impactedGameObject)
    {
        var materialType = impactedGameObject.GetComponent<MaterialType>();
        if (materialType == null)
            return null;
        foreach (var impactInfo in impactElemets)
        {
            if (impactInfo.MaterialType == materialType.TypeOfMaterial)
                return impactInfo.ImpactEffect;
        }
        return null;
    }
}